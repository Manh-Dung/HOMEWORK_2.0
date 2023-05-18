package com.example.foodorderingapp.Activity;

import android.os.Bundle;
import android.view.View;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;

import com.example.foodorderingapp.Adaptor.MessageAdaptor;
import com.example.foodorderingapp.Adaptor.NotificationAdaptor;
import com.example.foodorderingapp.Adaptor.StorageAdaptor;
import com.example.foodorderingapp.Domain.MessageDomain;
import com.example.foodorderingapp.Domain.NotificationDomain;
import com.example.foodorderingapp.Domain.PopularDomain;
import com.example.foodorderingapp.R;
import com.example.foodorderingapp.databinding.ActivitySupportBinding;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class SupportActivity extends AppCompatActivity {

    ActivitySupportBinding binding;
    DatabaseReference databaseReferenceSender, databaseReferenceReceiver, databaseReference;
    String senderRoom, receiverRoom,
            receiverId, receiverIdAdmin, receiverTest;
    MessageAdaptor messageAdaptor;
    NotificationAdaptor notificationAdaptor;
    Boolean isOpen = false;


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
        messageAdaptor = new MessageAdaptor(this);
        binding.messageRecycler.setAdapter(messageAdaptor);

        binding.notiRecycler.setLayoutManager(new LinearLayoutManager(this, LinearLayoutManager.VERTICAL, true));
        notificationAdaptor = new NotificationAdaptor(this);
        binding.notiRecycler.setAdapter(notificationAdaptor);

        databaseReference = FirebaseDatabase.getInstance().getReference("notifications").child(FirebaseAuth.getInstance().getUid());
        databaseReferenceSender = FirebaseDatabase.getInstance().getReference("chats").child(senderRoom);
        databaseReferenceReceiver = FirebaseDatabase.getInstance().getReference("chats").child(receiverRoom);

        databaseReferenceSender.orderByChild("msgId").addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot snapshot) {
                messageAdaptor.clear();
                for (DataSnapshot dataSnapshot : snapshot.getChildren()) {
                    MessageDomain messageDomain = dataSnapshot.getValue(MessageDomain.class);
                    messageAdaptor.add(messageDomain);
                }
            }

            @Override
            public void onCancelled(@NonNull DatabaseError error) {

            }
        });

        databaseReference.orderByChild("notiID").addListenerForSingleValueEvent(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot snapshot) {
                notificationAdaptor.clear();
                for (DataSnapshot dataSnapshot : snapshot.getChildren()) {
                    NotificationDomain notificationDomain = dataSnapshot.getValue(NotificationDomain.class);
                    notificationAdaptor.add(notificationDomain);
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

        binding.thongBao.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (!isOpen) {
                    binding.thongBao.setCompoundDrawablesRelativeWithIntrinsicBounds(null, null, getDrawable(R.drawable.down_image), null);
                    binding.notiView.setVisibility(View.VISIBLE);
                    isOpen = true;
                } else {
                    binding.thongBao.setCompoundDrawablesRelativeWithIntrinsicBounds(null, null, getDrawable(R.drawable.right_image), null);
                    binding.notiView.setVisibility(View.GONE);
                    isOpen = false;
                }
            }
        });
    }

    private void sendMessage(String message) {
        long millis = System.currentTimeMillis();
        java.util.Date messageId = new java.util.Date(millis);

        MessageDomain messageDomain = new MessageDomain(String.valueOf(messageId), FirebaseAuth.getInstance().getUid(), message);
        messageAdaptor.add(messageDomain);
        databaseReferenceSender.child(String.valueOf(messageId)).setValue(messageDomain);
        databaseReferenceReceiver.child(String.valueOf(messageId)).setValue(messageDomain);
    }


}