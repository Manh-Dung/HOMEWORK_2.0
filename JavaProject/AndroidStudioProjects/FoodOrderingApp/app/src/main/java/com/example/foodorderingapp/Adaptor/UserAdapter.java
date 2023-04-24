package com.example.foodorderingapp.Adaptor;

import android.content.Context;
import android.content.Intent;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.foodorderingapp.Domain.UserModel;
import com.example.foodorderingapp.R;
import com.example.foodorderingapp.Activity.SupportActivity;

import java.util.ArrayList;
import java.util.List;

public class UserAdapter extends RecyclerView.Adapter<UserAdapter.ViewHolder> {
    private Context context;
    private List<UserModel> userModelList;

    public UserAdapter(Context context) {
        this.context = context;
        userModelList = new ArrayList<>();
    }

    public void add(UserModel userModel){
        userModelList.add(userModel);
        notifyDataSetChanged();
    }

    public void clear(){
        userModelList.clear();
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
        UserModel userModel = userModelList.get(position);
        holder.name.setText(userModelList.get(position).getUserName());
        holder.email.setText(userModelList.get(position).getUserEmail());

        holder.itemView.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(context, SupportActivity.class);
                // Lấy id của item
                intent.putExtra("id", userModel.getUserId());
                context.startActivity(intent);
            }
        });
    }

    @Override
    public int getItemCount() {
        return userModelList.size();
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
