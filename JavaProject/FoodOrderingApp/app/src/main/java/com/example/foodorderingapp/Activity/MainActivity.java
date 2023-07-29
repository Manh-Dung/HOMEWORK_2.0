package com.example.foodorderingapp.Activity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.LinearLayout;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.example.foodorderingapp.Adaptor.CategoryAdaptor;
import com.example.foodorderingapp.Adaptor.PopularAdaptor;
import com.example.foodorderingapp.Adaptor.UserAdaptor;
import com.example.foodorderingapp.Domain.CategoryDomain;
import com.example.foodorderingapp.Domain.PopularDomain;
import com.example.foodorderingapp.R;
import com.google.android.material.floatingactionbutton.FloatingActionButton;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.database.DatabaseReference;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {
    private RecyclerView.Adapter adapter, adapter2;
    private RecyclerView recyclerViewCategoryList, recyclerViewPopularList;
    EditText searchMain;
    DatabaseReference databaseReference;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        recyclerViewCategory();
        recyclerViewPopular();
        bottomNavigation();
        searchBar();
    }

    private void searchBar() {
        searchMain = findViewById(R.id.searchMain);
        searchMain.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(MainActivity.this, SearchActivity.class);
                String searchKey = searchMain.getText().toString();
                intent.putExtra("searchKey", searchKey);
                startActivity(intent);
            }
        });
    }

    private void recyclerViewCategory() {
        // Có vẻ chỉ dùng cái LinearLayoutManager này để hiển thị dữ liệu, trong trường hợp bên dưới là theo chiều ngang
        LinearLayoutManager linearLayoutManager = new LinearLayoutManager(this, LinearLayoutManager.HORIZONTAL, false);
        recyclerViewCategoryList = findViewById(R.id.categoryRecyView);

        // Dùng cái recyclerViewCategoryList để hiển thị (đéo còn từ hay hơn), nhưng hiện tại vẫn chưa có dữ liệu
        recyclerViewCategoryList.setLayoutManager(linearLayoutManager);

        // Tạo 1 cái list có kiểu dữ liệu là CategoryDomain
        ArrayList<CategoryDomain> category = new ArrayList<>();
        category.add(new CategoryDomain("Pizza", "cat_1"));
        category.add(new CategoryDomain("Burger", "cat_2"));
        category.add(new CategoryDomain("Hot dog", "cat_3"));
        category.add(new CategoryDomain("Drink", "cat_4"));
        category.add(new CategoryDomain("Donut", "cat_5"));

        // Set adapter
        adapter = new CategoryAdaptor(category);
        recyclerViewCategoryList.setAdapter(adapter);
    }

    private void recyclerViewPopular() {
        LinearLayoutManager linearLayoutManager = new LinearLayoutManager(this, LinearLayoutManager.HORIZONTAL, false);
        recyclerViewPopularList = findViewById(R.id.popularRecyView);
        recyclerViewPopularList.setLayoutManager(linearLayoutManager);

        ArrayList<PopularDomain> foodList = new ArrayList<>();
        foodList.add(new PopularDomain("Pepperoni pizza", "pizza", "Xúc xích tiêu, Phô mai mozzarella, Oregano tươi, Tiêu đen xay, Sốt pizza", 200000));
        foodList.add(new PopularDomain("Cheese burger", "pop_2", "Thịt bò, Phô mai Gouda, Sốt đặc biệt, Xà lách, Cà chua", 190000));
        foodList.add(new PopularDomain("Vegetable pizza", "pop_3", "Dầu ô liu, Dầu thực vật, Kalamata rỗ, Cà chua bi, Oregano tươi, Húng quế", 180000));

        adapter2 = new PopularAdaptor(foodList);
        recyclerViewPopularList.setAdapter(adapter2);
    }

    private void bottomNavigation() {
        FloatingActionButton floatingActionButton = findViewById(R.id.cartBtn);
        LinearLayout homeBtn = findViewById(R.id.homeBtn);
        LinearLayout profileBtn = findViewById(R.id.profileBtn);
        LinearLayout settingBtn = findViewById(R.id.settingBtn);
        LinearLayout supportBtn = findViewById(R.id.supportBtn);

        floatingActionButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(new Intent(MainActivity.this, CartListActivity.class));
            }
        });

        homeBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(new Intent(MainActivity.this, MainActivity.class));
            }
        });

        profileBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(new Intent(MainActivity.this, ProfileActivity.class));
            }
        });

        settingBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(new Intent(MainActivity.this, SettingActivity.class));
            }
        });

        supportBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                // Nếu đây là tài khoản Admin thì vào trang dành riêng cho Admin
                if (FirebaseAuth.getInstance().getUid().equals("zJmVUQQc3bZZRkO7L2GX4OScmZw2")){
                    startActivity(new Intent(MainActivity.this, UserActivity.class));
                } else{
                    startActivity(new Intent(MainActivity.this, SupportActivity.class));
                }
            }
        });
    }
}