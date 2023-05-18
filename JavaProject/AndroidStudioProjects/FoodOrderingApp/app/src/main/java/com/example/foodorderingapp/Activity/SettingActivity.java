package com.example.foodorderingapp.Activity;

import android.content.Intent;
import android.os.Bundle;
import android.view.KeyEvent;
import android.view.View;
import android.view.inputmethod.EditorInfo;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import com.example.foodorderingapp.Adaptor.UserAdaptor;
import com.example.foodorderingapp.R;
import com.example.foodorderingapp.databinding.ActivitySettingBinding;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

public class SettingActivity extends AppCompatActivity {
    DatabaseReference databaseReference;
    ActivitySettingBinding binding;
    UserAdaptor userAdaptor;
    String userId;
    Boolean isOpen = false;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        binding = ActivitySettingBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        userId = FirebaseAuth.getInstance().getUid();
        databaseReference = FirebaseDatabase.getInstance().getReference("users").child(userId);
        userAdaptor = new UserAdaptor(this);

        binding.changePass.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (!isOpen) {
                    binding.changePass.setCompoundDrawablesRelativeWithIntrinsicBounds(null, null, getDrawable(R.drawable.down_image), null);
                    binding.edOld.setVisibility(View.VISIBLE);
                    binding.edNew.setVisibility(View.VISIBLE);
                    binding.edReNew.setVisibility(View.VISIBLE);
                    isOpen = true;
                } else {
                    binding.changePass.setCompoundDrawablesRelativeWithIntrinsicBounds(null, null, getDrawable(R.drawable.right_image), null);
                    binding.edOld.setVisibility(View.GONE);
                    binding.edNew.setVisibility(View.GONE);
                    binding.edReNew.setVisibility(View.GONE);
                    isOpen = false;
                }
            }
        });

        binding.edReNew.setOnEditorActionListener(new TextView.OnEditorActionListener() {
            @Override
            public boolean onEditorAction(TextView textView, int i, KeyEvent keyEvent) {
                if (i == EditorInfo.IME_ACTION_DONE) {
                    databaseReference.addValueEventListener(new ValueEventListener() {
                        @Override
                        public void onDataChange(@NonNull DataSnapshot snapshot) {
                            userAdaptor.clear();
                            String userPassword = snapshot.child("userPassword").getValue(String.class);
                            if (!userPassword.equals(binding.edOld.getText().toString())) {
                                Toast.makeText(SettingActivity.this, "Sai mật khẩu", Toast.LENGTH_SHORT).show();
                            }
                            else{
                                if (!binding.edNew.getText().toString().equals(binding.edReNew.getText().toString())) {
                                    Toast.makeText(SettingActivity.this, "Mật khẩu không trùng khớp", Toast.LENGTH_SHORT).show();
                                }
                                else{
                                    databaseReference.child("userPassword").setValue(binding.edNew.getText().toString());
                                    Toast.makeText(SettingActivity.this, "Đổi mật khẩu thành công", Toast.LENGTH_SHORT).show();
                                }
                            }
                        }
                        @Override
                        public void onCancelled(@NonNull DatabaseError error) {

                        }
                    });
                    return true;
                }
                return false;
            }
        });

        binding.logoutBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                FirebaseAuth.getInstance().signOut();
                startActivity(new Intent(SettingActivity.this, LoginActivity.class));
                finish();
            }
        });
    }


}