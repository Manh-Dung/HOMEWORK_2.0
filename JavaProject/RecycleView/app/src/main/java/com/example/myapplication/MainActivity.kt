package com.example.myapplication

import android.os.Bundle
import androidx.appcompat.app.AppCompatActivity
import com.example.myapplication.adapter.ItemAdapter
import com.example.myapplication.data.DataSource
import com.example.myapplication.databinding.ActivityMainBinding

class MainActivity : AppCompatActivity() {
    private lateinit var binding: ActivityMainBinding
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        val dataSet = DataSource().loadAffirmations()
        binding.recyclerView.adapter = ItemAdapter(this, dataSet)
        binding.recyclerView.setHasFixedSize(true)

    }
}