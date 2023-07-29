package com.example.foodorderingapp.Activity;

import android.os.Bundle;
import android.view.View;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import com.example.foodorderingapp.Adaptor.UserAdaptor;
import com.example.foodorderingapp.databinding.ActivityProfileBinding;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

public class ProfileActivity extends AppCompatActivity {
    DatabaseReference databaseReference;
    ActivityProfileBinding binding;
    UserAdaptor userAdaptor;
    String userId;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        binding = ActivityProfileBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        userId = FirebaseAuth.getInstance().getUid();
        databaseReference = FirebaseDatabase.getInstance().getReference("users").child(userId);
        userAdaptor = new UserAdaptor(this);

        loadInfo();

        binding.saveBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                changeInfo();
            }
        });
    }

    public void loadInfo(){
        databaseReference.addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot snapshot) {
                userAdaptor.clear();
                binding.edProName.setText(snapshot.child("userName").getValue(String.class));
                binding.edProEmail.setText(snapshot.child("userEmail").getValue(String.class));
                binding.edProPhone.setText(snapshot.child("userPhone").getValue(String.class));
                binding.edProAddress.setText(snapshot.child("userAddress").getValue(String.class));
                binding.edProBirth.setText(snapshot.child("userBirth").getValue(String.class));
            }

            @Override
            public void onCancelled(@NonNull DatabaseError error) {

            }
        });
    }
    public void changeInfo() {
        databaseReference.child("userName").setValue(binding.edProName.getText().toString());
        databaseReference.child("userEmail").setValue(binding.edProEmail.getText().toString());
        databaseReference.child("userPhone").setValue(binding.edProPhone.getText().toString());
        databaseReference.child("userAddress").setValue(binding.edProAddress.getText().toString());
        databaseReference.child("userBirth").setValue(binding.edProBirth.getText().toString());
        Toast.makeText(ProfileActivity.this, "Thay đổi thông tin thành công", Toast.LENGTH_SHORT).show();
    }
}