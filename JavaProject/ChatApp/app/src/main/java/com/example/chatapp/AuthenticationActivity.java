package com.example.chatapp;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

import com.example.chatapp.databinding.ActivityAuthenticationBinding;
import com.google.android.gms.tasks.OnSuccessListener;
import com.google.firebase.auth.AuthResult;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;
import com.google.firebase.auth.UserProfileChangeRequest;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.Query;
import com.google.firebase.database.ValueEventListener;

public class AuthenticationActivity extends AppCompatActivity {
    ActivityAuthenticationBinding binding;
    String name, email, password;
    DatabaseReference databaseReference;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        binding = ActivityAuthenticationBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        databaseReference = FirebaseDatabase.getInstance().getReference("users");

        binding.login.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                email = binding.email.getText().toString();
                password = binding.password.getText().toString();

                // Khởi tạo Firebase Database reference
                FirebaseDatabase database = FirebaseDatabase.getInstance();
                DatabaseReference myRef = database.getReference("users");

                // Tìm kiếm user có username = "nick1"
                Query query = myRef.orderByChild("userEmail").equalTo(email);
                query.addListenerForSingleValueEvent(new ValueEventListener() {
                    @Override
                    public void onDataChange(DataSnapshot dataSnapshot) {
                        // Lấy kết quả trả về
                        for (DataSnapshot ds : dataSnapshot.getChildren()) {
                            UserModel user = ds.getValue(UserModel.class);
                            if (user.getUserPassword().equals(password)) {
                                // Tìm thấy user cần tìm
                                // Do something...
                                Log.d("TAG", user.getUserName() + " - " + user.getUserPassword());
                                Toast.makeText(AuthenticationActivity.this, "Sign In Sucess!", Toast.LENGTH_SHORT).show();
                                login();
                            }
                            else {
                                Toast.makeText(AuthenticationActivity.this, "Vui lòng nhập đầy đủ thông tin!", Toast.LENGTH_SHORT).show();
                            }
                        }
                    }

                    @Override
                    public void onCancelled(DatabaseError databaseError) {
                        // Xử lý nếu có lỗi xảy ra
                    }
                });


            }
        });

        binding.signUp.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                name = binding.name.getText().toString();
                email = binding.email.getText().toString();
                password = binding.password.getText().toString();

                signUp();
            }
        });

    }

    private void login() {
        FirebaseAuth.getInstance().signInWithEmailAndPassword(email.trim(), password)
                .addOnSuccessListener(new OnSuccessListener<AuthResult>() {
                    @Override
                    public void onSuccess(AuthResult authResult) {
                        startActivity(new Intent(AuthenticationActivity.this, MainActivity.class));
                        finish();
                    }
                });
    }

    private void signUp() {
        FirebaseAuth.getInstance().createUserWithEmailAndPassword(email.trim(), password)
                .addOnSuccessListener(new OnSuccessListener<AuthResult>() {
                    @Override
                    public void onSuccess(AuthResult authResult) {
                        UserProfileChangeRequest userProfileChangeRequest = new UserProfileChangeRequest.Builder().setDisplayName(name).build();
                        FirebaseUser firebaseUser = FirebaseAuth.getInstance().getCurrentUser();
                        firebaseUser.updateProfile(userProfileChangeRequest);
                        UserModel userModel = new UserModel(FirebaseAuth.getInstance().getUid(), name, email, password);
                        databaseReference.child(FirebaseAuth.getInstance().getUid()).setValue(userModel);
                        startActivity(new Intent(AuthenticationActivity.this, MainActivity.class));
                        finish();
                    }
                });
    }

    @Override
    protected void onStart() {
        super.onStart();
        if (FirebaseAuth.getInstance().getCurrentUser() != null) {
            startActivity(new Intent(AuthenticationActivity.this, MainActivity.class));
            finish();
        }
    }

}