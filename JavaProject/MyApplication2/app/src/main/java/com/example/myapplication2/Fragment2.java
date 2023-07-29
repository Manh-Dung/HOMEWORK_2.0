package com.example.myapplication2;

import android.os.Bundle;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentResultListener;
import androidx.navigation.NavController;
import androidx.navigation.Navigation;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.TextView;


public class Fragment2 extends Fragment {
    View view;
    Button btnFrag2;
    TextView txt2;
    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        view = inflater.inflate(R.layout.fragment_2, container, false);
        btnFrag2 = (Button) view.findViewById(R.id.btnFrag2);
        txt2 = (TextView) view.findViewById(R.id.txt2);

//        Bundle bundle = this.getArguments();
//        String txt = this.getArguments().getString("temp");
//        if(bundle != null){
//            // handle your code here.
//            txt2.setText(txt);
//        }

        btnFrag2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                NavController navController = Navigation.findNavController(view);
                navController.navigate(R.id.action_fragment2_to_fragment1);
            }
        });
        return view;
    }

}