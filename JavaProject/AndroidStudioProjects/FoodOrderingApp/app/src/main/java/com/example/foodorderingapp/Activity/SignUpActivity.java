package com.example.foodorderingapp.Activity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

import com.example.foodorderingapp.Domain.UserDomain;
import com.example.foodorderingapp.databinding.ActivitySignUpBinding;
import com.google.android.gms.tasks.OnSuccessListener;
import com.google.firebase.auth.AuthResult;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;
import com.google.firebase.auth.UserProfileChangeRequest;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;

public class SignUpActivity extends AppCompatActivity {
    ActivitySignUpBinding binding;
    DatabaseReference databaseReference;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        binding = ActivitySignUpBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        databaseReference = FirebaseDatabase.getInstance().getReference("users");
        binding.signUpBtn.setOnClickListener(new View.OnClickListener() {

            @Override
            public void onClick(View view) {
                signUp();
            }
        });
    }

    private void signUp() {

        if (!binding.edPassword.getText().toString().equals(binding.edRePassword.getText().toString())) {
            Toast.makeText(SignUpActivity.this, "Mật khẩu nhập lại không trùng khớp!", Toast.LENGTH_SHORT).show();
        }
        if (binding.edEmail.getText().toString().isEmpty()
                || binding.edPassword.getText().toString().isEmpty()
                || binding.edRePassword.getText().toString().isEmpty()
                || binding.edName.getText().toString().isEmpty()
                || binding.edAddress.getText().toString().isEmpty()
                || binding.edPhoneNumber.getText().toString().isEmpty()
                || binding.edBirthday.getText().toString().isEmpty()) {
            Toast.makeText(SignUpActivity.this, "Vui lòng nhập đầy đủ thông tin!", Toast.LENGTH_SHORT).show();
        } else {
            FirebaseAuth.getInstance().createUserWithEmailAndPassword(binding.edEmail.getText().toString().trim(), binding.edPassword.getText().toString())
                    .addOnSuccessListener(new OnSuccessListener<AuthResult>() {
                        @Override
                        public void onSuccess(AuthResult authResult) {
                            UserProfileChangeRequest userProfileChangeRequest = new UserProfileChangeRequest.Builder().setDisplayName(binding.edName.getText().toString()).build();
                            FirebaseUser firebaseUser = FirebaseAuth.getInstance().getCurrentUser();
                            firebaseUser.updateProfile(userProfileChangeRequest);
                            UserDomain userDomain = new UserDomain(FirebaseAuth.getInstance().getUid()
                                    , binding.edName.getText().toString()
                                    , binding.edEmail.getText().toString()
                                    , binding.edPassword.getText().toString()
                                    , binding.edPhoneNumber.getText().toString()
                                    , binding.edAddress.getText().toString()
                                    , binding.edBirthday.getText().toString());
                            databaseReference.child(FirebaseAuth.getInstance().getUid()).setValue(userDomain);
                            startActivity(new Intent(SignUpActivity.this, IntroActivity.class));
                            finish();
                        }
                    });
        }
    }

    @Override
    protected void onStart() {
        super.onStart();
        if (FirebaseAuth.getInstance().getCurrentUser() != null) {
            startActivity(new Intent(SignUpActivity.this, IntroActivity.class));
            finish();
        }
    }
}