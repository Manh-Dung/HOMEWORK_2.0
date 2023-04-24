package com.example.androidstudy;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.widget.TextView;

import com.example.androidstudy.databinding.ActivityMainBinding;
import com.example.androidstudy.databinding.ActivityTestBinding;

public class TestActivity extends AppCompatActivity {
    ActivityTestBinding binding;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        binding = ActivityTestBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());


        Intent intent = getIntent();
        binding.testTxt.setText(intent.getExtras().getString("key1"));
    }
}