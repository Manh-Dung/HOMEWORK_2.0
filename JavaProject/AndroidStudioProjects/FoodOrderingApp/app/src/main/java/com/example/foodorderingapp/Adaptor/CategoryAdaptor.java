package com.example.foodorderingapp.Adaptor;

import android.content.Intent;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.constraintlayout.widget.ConstraintLayout;
import androidx.core.content.ContextCompat;
import androidx.recyclerview.widget.RecyclerView;

import com.example.foodorderingapp.Activity.SearchActivity;
import com.example.foodorderingapp.Domain.CategoryDomain;
import com.example.foodorderingapp.R;
import com.bumptech.glide.Glide;
import com.example.foodorderingapp.Activity.ShowDetailActivity;

import java.io.Serializable;
import java.util.ArrayList;

public class CategoryAdaptor extends RecyclerView.Adapter<CategoryAdaptor.ViewHolder> {
    // Khởi tạo một list có kiểu dữ liệu CateDomain
    ArrayList<CategoryDomain> categoryDomains;

    // Constructor, khỏi nghĩ nhiều
    public CategoryAdaptor(ArrayList<CategoryDomain> categoryDomains) {
        this.categoryDomains = categoryDomains;
    }

    // Hàm abstract này buộc phải có để tạo và trả về một ViewHolder, trong trường hợp này là viewholder_category
    // ViewGroup parent là cái View chứa các ViewHolder, ở trong trường hợp này là RecyclerView
    // int viewType được sử dụng để phân biệt các loại View khác nhau mà Adapter có thể cần tạo.
    // Trong trường hợp này, nó không được sử dụng và có thể bị bỏ qua.
    public ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {

        // LayoutInflater để tạo một View mới từ layout XML (R.layout.viewholder_category)
        // Và chèn nó vào parent View
        // false được truyền vào inflate để ngăn cản View mới được liên kết với parent ngay lập tức
        // (vì nó sẽ được gắn vào RecyclerView bằng cách khác).
        View inflate = LayoutInflater.from(parent.getContext()).inflate(R.layout.viewholder_category, parent, false);
        return new ViewHolder(inflate);
    }

    // Cái này buộc phải có để hiển thị dữ liệu trong ViewHolder
    @Override
    public void onBindViewHolder(@NonNull CategoryAdaptor.ViewHolder holder, int position) {

        // Hiển thị tên theo vị trí
        holder.categoryName.setText(categoryDomains.get(position).getTitle());
        String picUrl = "";
        switch (position) {
            case 0: {
                picUrl = "cat_1";
                holder.mainLayout.setBackground(ContextCompat.getDrawable(holder.itemView.getContext(), R.drawable.cate_background1));
                break;
            }
            case 1: {
                picUrl = "cat_2";
                holder.mainLayout.setBackground(ContextCompat.getDrawable(holder.itemView.getContext(), R.drawable.cate_background2));
                break;
            }
            case 2: {
                picUrl = "cat_3";
                holder.mainLayout.setBackground(ContextCompat.getDrawable(holder.itemView.getContext(), R.drawable.cate_background3));
                break;
            }
            case 3: {
                picUrl = "cat_4";
                holder.mainLayout.setBackground(ContextCompat.getDrawable(holder.itemView.getContext(), R.drawable.cate_background4));
                break;
            }
            case 4: {
                picUrl = "cat_5";
                holder.mainLayout.setBackground(ContextCompat.getDrawable(holder.itemView.getContext(), R.drawable.cate_background5));
                break;
            }

        }

        // Biến bên dưới để lấy id của tài nguyên (itemView) bằng cách sử dụng hàm getResources()
        // Trong đó picUrl là tên file ảnh, drawable là loại tài nguyên, cái thứ 3 là tên package
        // Còn cách khác ở file PopularAdaptor
        int drawableResourceId = holder.itemView.getContext().getResources().getIdentifier(picUrl, "drawable", holder.itemView.getContext().getPackageName());

        // Sử dụng thư viện Glide để lấy ảnh từ id tài nguyên và hiển thị lên ImageView 'categoryPic'
        // Trong đó context được truyền vào được lấy từ id của tài nguyên 'itemView', hàm load() được sử dụng để tải ảnh, còn into() để chọn nơi tải ảnh
        Glide.with(holder.itemView.getContext()).load(drawableResourceId).into(holder.categoryPic);
        holder.categoryPic.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                // Hiển thị mỗi cái itemView có chứa
                Intent intent = new Intent(holder.itemView.getContext(), SearchActivity.class);

                // Tạo 1 key tương ứng với từng đối tượng khác nhau
                intent.putExtra("searchKey", categoryDomains.get(position).getTitle());
                holder.itemView.getContext().startActivity(intent);
            }
        });
    }

    // Hàm bắt buộc phải có để lấy số lượng các thành phần trong list CategoryDomain
    @Override
    public int getItemCount() {
        return categoryDomains.size();
    }

    // Class ViewHolder này kế thừa class RecyclerView.ViewHolder
    public class ViewHolder extends RecyclerView.ViewHolder {
        TextView categoryName;
        ImageView categoryPic;
        ConstraintLayout mainLayout;

        // Tham chiếu đến từng thành phần trong View mẫu, ở trong trường hợp này là viewholder_category
        public ViewHolder(@NonNull View itemView) {
            super(itemView);
            categoryName = itemView.findViewById(R.id.categoryName);
            categoryPic = itemView.findViewById(R.id.categoryPic);
            mainLayout = itemView.findViewById(R.id.mainLayout);
        }
    }

}
