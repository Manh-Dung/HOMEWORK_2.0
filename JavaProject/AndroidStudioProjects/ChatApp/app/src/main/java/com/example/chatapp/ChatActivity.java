package com.example.chatapp;

import android.os.Bundle;
import android.view.View;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;

import com.example.chatapp.databinding.ActivityChatBinding;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

import java.util.Random;

public class ChatActivity extends AppCompatActivity {
    ActivityChatBinding binding;
    DatabaseReference databaseReferenceSender, databaseReferenceReceiver;
    String senderRoom, receiverRoom,
            receiverId;
    MessageAdapter messageAdapter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        binding = ActivityChatBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        // Lấy id của tài khoản nhận tin nhắn hiện tại
        receiverId = getIntent().getStringExtra("id");

        // Tạo ra 1 id gửi bằng id của tài khoản hiện tại + id tài khoản nhận
        senderRoom = FirebaseAuth.getInstance().getUid() + receiverId;
        // Tạo ra 1 id gửi bằng id tài khoản nhận + id của tài khoản hiện tại
        receiverRoom = receiverId + FirebaseAuth.getInstance().getUid();

        binding.recycler.setLayoutManager(new LinearLayoutManager(this));
        messageAdapter = new MessageAdapter(this);
        binding.recycler.setAdapter(messageAdapter);


        databaseReferenceSender = FirebaseDatabase.getInstance().getReference("chats").child(senderRoom);
        databaseReferenceReceiver = FirebaseDatabase.getInstance().getReference("chats").child(receiverRoom);

        databaseReferenceSender.orderByChild("msgId").addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot snapshot) {
                messageAdapter.clear();
                for (DataSnapshot dataSnapshot : snapshot.getChildren()) {
                    MessageModel messageModel = dataSnapshot.getValue(MessageModel.class);
                    messageAdapter.add(messageModel);
                }
            }

            @Override
            public void onCancelled(@NonNull DatabaseError error) {

            }
        });

        binding.sendMessage.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String message = binding.messageEd.getText().toString();
                if (message.trim().length() > 0) {

//                    sendMessage(message);
                    sendEncryptedMessage(message);
                }
            }
        });
    }

// Gửi tin nhắn không mã hóa
    private void sendMessage(String message) {
        long millis = System.currentTimeMillis();
        java.util.Date messageId = new java.util.Date(millis);
//        String messageId = UUID.randomUUID().toString();

        MessageModel messageModel = new MessageModel(String.valueOf(messageId), FirebaseAuth.getInstance().getUid(), message);
        messageAdapter.add(messageModel);
        databaseReferenceSender.child(String.valueOf(messageId)).setValue(messageModel);
        databaseReferenceReceiver.child(String.valueOf(messageId)).setValue(messageModel);
    }

    private void sendEncryptedMessage(String message) {
        long millis = System.currentTimeMillis();
        java.util.Date messageId = new java.util.Date(millis);

        // Key các kiểu
        String p = "2579";
        String g = "2";
        String a = "759";

        String encryptedMessage = encryptElgamal(p, g, a, message);
        MessageModel messageModel = new MessageModel(String.valueOf(messageId), FirebaseAuth.getInstance().getUid(), encryptedMessage);

        messageAdapter.add(messageModel);
        databaseReferenceSender.child(String.valueOf(messageId)).setValue(messageModel);
        databaseReferenceReceiver.child(String.valueOf(messageId)).setValue(messageModel);
    }

    // Toàn bộ những hàm bên dưới để phục vụ cho mã hóa
    public static String encryptElgamal(String p, String g, String a, String text) {
        long longP = Long.parseLong(p);
        long longG = Long.parseLong(g);
        long longA = Long.parseLong(a);
        String y1 = null, y2 = null;
//        long p = 2579;
//        long g = 2;

        String encryptedText = "";
        for (int i = 0; i < text.length(); i++) {
            char c = text.charAt(i);
            Random random = new Random();
            long r = random.nextInt(1000);
            long h = powerMod(longG, longA % phi(longP), longP);
            y1 = Long.toString(powerMod(longG, r % phi(longP), longP));
            y2 = Long.toString((long) c * powerMod(h, r % phi(longP), longP));
            encryptedText = encryptedText + y1 + "," + y2;
            encryptedText = encryptedText + ";";
        }

        return encryptedText;
    }

    public static char decryptElgamal(String p, String a, String y1, String y2) {
        long longP = Long.parseLong(p);
        long longA = Long.parseLong(a);
        long longY1 = Long.parseLong(y1);
        long longY2 = Long.parseLong(y2);
        long x = powerMod(powerMod(longY2, 1 % phi(longP), longP) * modInverse(powerMod(longY1, longA % phi(longP), longP), longP), 1 % phi(longP), longP);

        return (char) x;
    }

    public static long powerMod(long a, long b, long n) {
        long result = 1;

        a = a % n;

        while (b > 0) {
            if (b % 2 == 1) {
                result = (result * a) % n;
            }

            b = b >> 1;
            a = (a * a) % n;
        }

        return result;
    }

    public static long phi(long n) {
        long result = n;

        for (long i = 2; i * i <= n; i++) {
            if (n % i == 0) {
                while (n % i == 0) {
                    n /= i;
                }

                result -= result / i;
            }
        }

        if (n > 1) {
            result -= result / n;
        }

        return result;
    }

    public static long[] extendedEuclid(long a, long b) {
        if (b == 0) {
            return new long[]{a, 1, 0};
        }
        long[] vals = extendedEuclid(b, a % b);
        long d = vals[0];
        long x = vals[2];
        long y = vals[1] - (a / b) * vals[2];
        return new long[]{d, x, y};
    }

    public static long modInverse(long a, long m) {
        long[] vals = extendedEuclid(a, m);
        long d = vals[0];
        long x = vals[1];
        long y = vals[2];
        if (d != 1) {
            throw new ArithmeticException("Inverse does not exist.");
        }
        return (x % m + m) % m;
    }
}