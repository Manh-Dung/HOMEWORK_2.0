package com.example.learnactivity;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;

import com.example.learnactivity.databinding.ActivityMainBinding;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    ActivityMainBinding binding;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        binding = ActivityMainBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        ArrayList<Integer> list = new ArrayList<>();
        for (int i = 0; i < 5; i++){
            list.add(i);
        }

    }
}