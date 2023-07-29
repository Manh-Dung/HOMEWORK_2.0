package com.example.myapplication;

import android.os.Bundle;

import androidx.fragment.app.Fragment;
import androidx.navigation.Navigation;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.TextView;

public class Fragment1 extends Fragment {
    View view;
    Button btnFrag1;
    TextView txt1;
    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        view = inflater.inflate(R.layout.fragment_1, container, false);
        btnFrag1 = (Button) view.findViewById(R.id.btnFrag1);
        txt1 = (TextView) view.findViewById(R.id.txt1);
//        btnFrag1.setOnClickListener(new View.OnClickListener() {
//            @Override
//            public void onClick(View view) {
//                txt1.setText("Cak1");
//            }
//        });
        btnFrag1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Navigation.findNavController(view).navigate(R.id.action_fragment1_to_fragment2);
            }
        });
        return view;
    }
}