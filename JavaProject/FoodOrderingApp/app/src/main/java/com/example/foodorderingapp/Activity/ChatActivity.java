package com.example.foodorderingapp.Activity;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;

import android.os.Bundle;
import android.view.View;

import com.example.foodorderingapp.Adaptor.MessageAdaptor;
import com.example.foodorderingapp.Domain.MessageDomain;
import com.example.foodorderingapp.R;
import com.example.foodorderingapp.databinding.ActivityChatBinding;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

public class ChatActivity extends AppCompatActivity {

    ActivityChatBinding binding;
    DatabaseReference databaseReferenceSender, databaseReferenceReceiver;
    String senderRoom, receiverRoom,
            receiverId;
    MessageAdaptor messageAdapter;
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
        messageAdapter = new MessageAdaptor(this);
        binding.recycler.setAdapter(messageAdapter);


        databaseReferenceSender = FirebaseDatabase.getInstance().getReference("chats").child(senderRoom);
        databaseReferenceReceiver = FirebaseDatabase.getInstance().getReference("chats").child(receiverRoom);

        databaseReferenceSender.orderByChild("msgId").addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot snapshot) {
                messageAdapter.clear();
                for (DataSnapshot dataSnapshot : snapshot.getChildren()) {
                    MessageDomain messageDomain = dataSnapshot.getValue(MessageDomain.class);
                    messageAdapter.add(messageDomain);
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
                    sendMessage(message);
                }
            }
        });
    }

    private void sendMessage(String message) {
        long millis = System.currentTimeMillis();
        java.util.Date messageId = new java.util.Date(millis);
//        String messageId = UUID.randomUUID().toString();

        MessageDomain messageModel = new MessageDomain(String.valueOf(messageId), FirebaseAuth.getInstance().getUid(), message);
        messageAdapter.add(messageModel);
        databaseReferenceSender.child(String.valueOf(messageId)).setValue(messageModel);
        databaseReferenceReceiver.child(String.valueOf(messageId)).setValue(messageModel);
    }
}