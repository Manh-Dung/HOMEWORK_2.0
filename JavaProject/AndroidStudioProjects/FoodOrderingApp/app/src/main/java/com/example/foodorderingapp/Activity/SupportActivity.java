package com.example.foodorderingapp.Activity;

import android.os.Bundle;
import android.view.View;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;

import com.example.foodorderingapp.Adaptor.MessageAdapter;
import com.example.foodorderingapp.Domain.MessageModel;
import com.example.foodorderingapp.databinding.ActivitySupportBinding;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

public class SupportActivity extends AppCompatActivity {

    ActivitySupportBinding binding;
    DatabaseReference databaseReferenceSender, databaseReferenceReceiver;
    String senderRoom, receiverRoom,
            receiverId, receiverIdAdmin, receiverTest;
    MessageAdapter messageAdapter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        binding = ActivitySupportBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

//        receiverId = getIntent().getStringExtra("id");
        receiverIdAdmin = "zJmVUQQc3bZZRkO7L2GX4OScmZw2";

        senderRoom = FirebaseAuth.getInstance().getUid() + receiverIdAdmin;
        receiverRoom = receiverIdAdmin + FirebaseAuth.getInstance().getUid();

        binding.messageRecycler.setLayoutManager(new LinearLayoutManager(this));
        messageAdapter = new MessageAdapter(this);
        binding.messageRecycler.setAdapter(messageAdapter);

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
                    sendMessage(message);
                }
            }
        });
    }

    private void sendMessage(String message) {
        long millis = System.currentTimeMillis();
        java.util.Date messageId = new java.util.Date(millis);

        MessageModel messageModel = new MessageModel(String.valueOf(messageId), FirebaseAuth.getInstance().getUid(), message);
        messageAdapter.add(messageModel);
        databaseReferenceSender.child(String.valueOf(messageId)).setValue(messageModel);
        databaseReferenceReceiver.child(String.valueOf(messageId)).setValue(messageModel);
    }
}