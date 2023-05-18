package com.example.foodorderingapp.Adaptor;

import android.content.Context;
import android.content.Intent;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.foodorderingapp.Activity.ChatActivity;
import com.example.foodorderingapp.Domain.UserDomain;
import com.example.foodorderingapp.R;
import com.example.foodorderingapp.Activity.SupportActivity;
import com.google.firebase.auth.FirebaseAuth;

import java.util.ArrayList;
import java.util.List;

public class UserAdaptor extends RecyclerView.Adapter<UserAdaptor.ViewHolder> {
    private Context context;
    private List<UserDomain> userDomainList;

    public UserAdaptor(Context context) {
        this.context = context;
        userDomainList = new ArrayList<>();
    }

    public void add(UserDomain userDomain){
        userDomainList.add(userDomain);
        notifyDataSetChanged();
    }

    public void clear(){
        userDomainList.clear();
        notifyDataSetChanged();
    }

    @NonNull
    @Override
    public ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View inflate = LayoutInflater.from(parent.getContext()).inflate(R.layout.user_row, parent, false);
        return new ViewHolder(inflate);
    }

    @Override
    public void onBindViewHolder(@NonNull ViewHolder holder, int position) {
        UserDomain userDomain = userDomainList.get(position);
        holder.name.setText(userDomainList.get(position).getUserName());
        holder.email.setText(userDomainList.get(position).getUserEmail());

        holder.itemView.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (FirebaseAuth.getInstance().getUid().equals("zJmVUQQc3bZZRkO7L2GX4OScmZw2")){
                    Intent intent = new Intent(context, ChatActivity.class);
                    // Lấy id của item
                    intent.putExtra("id", userDomain.getUserId());
                    context.startActivity(intent);
                } else {
                    Intent intent = new Intent(context, SupportActivity.class);
                    // Lấy id của item
                    intent.putExtra("id", userDomain.getUserId());
                    context.startActivity(intent);
                }

            }
        });
    }

    @Override
    public int getItemCount() {
        return userDomainList.size();
    }


    public class ViewHolder extends RecyclerView.ViewHolder{
        private TextView name, email;
        public ViewHolder(@NonNull View itemView) {
            super(itemView);
            name = itemView.findViewById(R.id.userName);
            email = itemView.findViewById(R.id.userEmail);
        }
    }
}
