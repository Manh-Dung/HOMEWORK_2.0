package com.example.foodorderingapp.Adaptor;

import android.content.Intent;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.bumptech.glide.Glide;
import com.example.foodorderingapp.Activity.ShowDetailActivity;
import com.example.foodorderingapp.Domain.PopularDomain;
import com.example.foodorderingapp.R;

import java.util.ArrayList;

public class StorageAdaptor extends RecyclerView.Adapter<StorageAdaptor.ViewHolder> {
    ArrayList<PopularDomain> foodStorage;
    public StorageAdaptor(ArrayList<PopularDomain> foodStorage) {
        this.foodStorage = foodStorage;
    }

    @Override
    public StorageAdaptor.ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View inflate = LayoutInflater.from(parent.getContext()).inflate(R.layout.viewholder_storage, parent, false);
        return new ViewHolder(inflate);
    }

    @Override
    public void onBindViewHolder(@NonNull StorageAdaptor.ViewHolder holder, int position) {
        holder.title.setText(foodStorage.get(position).getTitle());
        holder.fee.setText(String.valueOf(foodStorage.get(position).getFee()));

        int drawableResourceId = holder.itemView.getContext().getResources().getIdentifier(foodStorage.get(position).getPic(), "drawable", holder.itemView.getContext().getPackageName());
        Glide.with(holder.itemView.getContext()).load(drawableResourceId).into(holder.pic);
        holder.pic.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                // Hiển thị mỗi cái itemView có chứa
                Intent intent = new Intent(holder.itemView.getContext(), ShowDetailActivity.class);

                // Tạo 1 key tương ứng với từng đối tượng khác nhau
                intent.putExtra("object", foodStorage.get(position));
                holder.itemView.getContext().startActivity(intent);
            }
        });

    }


    @Override
    public int getItemCount() {
        return foodStorage.size();
    }

    public class ViewHolder extends RecyclerView.ViewHolder {
        TextView title, fee;
        ImageView pic;

        public ViewHolder(@NonNull View itemView) {
            super(itemView);
            title = itemView.findViewById(R.id.titleSearch);
            fee = itemView.findViewById(R.id.feeSearch);
            pic = itemView.findViewById(R.id.picSearch);
        }
    }
}
