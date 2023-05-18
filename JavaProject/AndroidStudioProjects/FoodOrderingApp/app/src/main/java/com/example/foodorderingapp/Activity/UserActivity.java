package com.example.foodorderingapp.Activity;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;

import android.os.Bundle;

import com.example.foodorderingapp.Adaptor.UserAdaptor;
import com.example.foodorderingapp.Domain.UserDomain;
import com.example.foodorderingapp.R;
import com.example.foodorderingapp.databinding.ActivityUserBinding;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

public class UserActivity extends AppCompatActivity {

    ActivityUserBinding binding;
    DatabaseReference databaseReference;
    UserAdaptor userAdaptor;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        binding = ActivityUserBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        userAdaptor = new UserAdaptor(this);
        binding.recycler.setAdapter(userAdaptor);
        binding.recycler.setLayoutManager(new LinearLayoutManager(this));

        databaseReference = FirebaseDatabase.getInstance().getReference("users");
        databaseReference.addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot snapshot) {
                userAdaptor.clear();
                for (DataSnapshot dataSnapshot : snapshot.getChildren()) {
                    String uid = dataSnapshot.getKey();
                    if (!uid.equals(FirebaseAuth.getInstance().getUid())) {
                        UserDomain userDomain = dataSnapshot.getValue(UserDomain.class);
                        userAdaptor.add(userDomain);
                    }
                }
            }

            @Override
            public void onCancelled(@NonNull DatabaseError error) {

            }
        });
    }
}