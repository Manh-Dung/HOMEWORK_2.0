package com.example.foodorderingapp.Activity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.example.foodorderingapp.Adaptor.CartListAdaptor;
import com.example.foodorderingapp.Adaptor.FoodFeeComparator;
import com.example.foodorderingapp.Adaptor.FoodTittleComparator;
import com.example.foodorderingapp.Adaptor.StorageAdaptor;
import com.example.foodorderingapp.Domain.PopularDomain;
import com.example.foodorderingapp.databinding.ActivitySearchBinding;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class SearchActivity extends AppCompatActivity {
    ActivitySearchBinding binding;
    private RecyclerView.Adapter adapter3;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        binding = ActivitySearchBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        search(initList());
        spinnerInit();
        tittleSpinnerDrop();
        feeSpinnerDrop();
        bottomNavigation();

        binding.searchStorage.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (binding.searchStorage.getText().toString().length() > 0) {
                    LinearLayoutManager linearLayoutManager = new LinearLayoutManager(SearchActivity.this, LinearLayoutManager.VERTICAL, false);
                    binding.storageRecycleView.setLayoutManager(linearLayoutManager);

                    ArrayList<PopularDomain> result = findFoodByTittle(binding.searchStorage.getText().toString(), initList());

                    adapter3 = new StorageAdaptor(result);
                    binding.storageRecycleView.setAdapter(adapter3);
                } else {
                    LinearLayoutManager linearLayoutManager = new LinearLayoutManager(SearchActivity.this, LinearLayoutManager.VERTICAL, false);
                    binding.storageRecycleView.setLayoutManager(linearLayoutManager);

                    adapter3 = new StorageAdaptor(initList());
                    binding.storageRecycleView.setAdapter(adapter3);
                }
            }
        });
    }

    private void search(ArrayList<PopularDomain> foodStorage) {
        Intent intent = getIntent();
        binding.searchStorage.setText(intent.getExtras().getString("searchKey"));
        if (binding.searchStorage.getText().toString().length() > 0) {
            foodStorage = initList();
            LinearLayoutManager linearLayoutManager = new LinearLayoutManager(this, LinearLayoutManager.VERTICAL, false);
            binding.storageRecycleView.setLayoutManager(linearLayoutManager);

            ArrayList<PopularDomain> result = findFoodByTittle(binding.searchStorage.getText().toString(), foodStorage);

            adapter3 = new StorageAdaptor(result);
            binding.storageRecycleView.setAdapter(adapter3);
        } else {
            foodStorage = initList();

            LinearLayoutManager linearLayoutManager = new LinearLayoutManager(this, LinearLayoutManager.VERTICAL, false);
            binding.storageRecycleView.setLayoutManager(linearLayoutManager);

            adapter3 = new StorageAdaptor(foodStorage);
            binding.storageRecycleView.setAdapter(adapter3);
        }

    }

    private void feeSort(ArrayList<PopularDomain> foodStorage) {
        foodStorage = initList();

        LinearLayoutManager linearLayoutManager = new LinearLayoutManager(this, LinearLayoutManager.VERTICAL, false);
        binding.storageRecycleView.setLayoutManager(linearLayoutManager);

        Collections.sort(foodStorage, new FoodFeeComparator());
        adapter3 = new StorageAdaptor(foodStorage);
        binding.storageRecycleView.setAdapter(adapter3);
    }

    private void feeSortRevert(ArrayList<PopularDomain> foodStorage) {
        foodStorage = initList();

        LinearLayoutManager linearLayoutManager = new LinearLayoutManager(this, LinearLayoutManager.VERTICAL, false);
        binding.storageRecycleView.setLayoutManager(linearLayoutManager);

        Collections.sort(foodStorage, new FoodFeeComparator().reversed());
        adapter3 = new StorageAdaptor(foodStorage);
        binding.storageRecycleView.setAdapter(adapter3);
    }

    private void tittleSort(ArrayList<PopularDomain> foodStorage) {
        foodStorage = initList();

        LinearLayoutManager linearLayoutManager = new LinearLayoutManager(this, LinearLayoutManager.VERTICAL, false);
        binding.storageRecycleView.setLayoutManager(linearLayoutManager);

        Collections.sort(foodStorage, new FoodTittleComparator());
        adapter3 = new StorageAdaptor(foodStorage);
        binding.storageRecycleView.setAdapter(adapter3);
    }

    private void tittleSortRevert(ArrayList<PopularDomain> foodStorage) {
        foodStorage = initList();

        LinearLayoutManager linearLayoutManager = new LinearLayoutManager(this, LinearLayoutManager.VERTICAL, false);
        binding.storageRecycleView.setLayoutManager(linearLayoutManager);

        Collections.sort(foodStorage, new FoodTittleComparator().reversed());
        adapter3 = new StorageAdaptor(foodStorage);
        binding.storageRecycleView.setAdapter(adapter3);
    }

    private ArrayList<PopularDomain> initList() {
        ArrayList<PopularDomain> foodStorage = new ArrayList<>();
        foodStorage.add(new PopularDomain("Pepperoni pizza", "pizza", "Xúc xích tiêu, Phô mai mozzarella, Oregano tươi, Tiêu đen xay, Sốt pizza", 200000));
        foodStorage.add(new PopularDomain("Cheese burger", "pop_2", "Thịt bò, Phô mai Gouda, Sốt đặc biệt, Xà lách, Cà chua", 190000));
        foodStorage.add(new PopularDomain("Vegetable pizza", "pop_3", "Dầu ô liu, Dầu thực vật, Kalamata rỗ, Cà chua bi, Oregano tươi, Húng quế", 180000));
        foodStorage.add(new PopularDomain("Bánh mì bò hầm", "banh_mi_bo_ham", "Xúc xích tiêu, Phô mai mozzarella, Oregano tươi, Tiêu đen xay, Sốt pizza", 200000));
        foodStorage.add(new PopularDomain("Bánh mì gà sốt cay", "banh_mi_ga_sot_cay", "Thịt bò, Phô mai Gouda, Sốt đặc biệt, Xà lách, Cà chua", 190000));
        foodStorage.add(new PopularDomain("Bánh mỳ thịt nướng", "banh_mi_thit_nuong", "Dầu ô liu, Dầu thực vật, Kalamata rỗ, Cà chua bi, Oregano tươi, Húng quế", 180000));
        foodStorage.add(new PopularDomain("Burger bò phô mai", "burger_bo_pho_mai", "Xúc xích tiêu, Phô mai mozzarella, Oregano tươi, Tiêu đen xay, Sốt pizza", 200000));
        foodStorage.add(new PopularDomain("Burger đặc biệt", "burger_dac_biet", "Thịt bò, Phô mai Gouda, Sốt đặc biệt, Xà lách, Cà chua", 190000));
        foodStorage.add(new PopularDomain("Burger thịt xông khói", "burger_thit_xongg_khoi", "Dầu ô liu, Dầu thực vật, Kalamata rỗ, Cà chua bi, Oregano tươi, Húng quế", 180000));
        foodStorage.add(new PopularDomain("Trà sữa matcha", "tra_sua_matcha", "Trà sữa matcha là một loại đồ uống giải khát được làm từ bột trà xanh Nhật Bản, nước nóng và sữa", 50000));
        foodStorage.add(new PopularDomain("Trà sữa trân châu", "tra_sua_tran_chau", "Trà sữa trân châu được làm từ trà đen hoặc trà xanh, sữa tươi và đường. Trân châu là một loại bột sắn được làm thành hình cầu nhỏ và có vị ngọt", 45000));
        foodStorage.add(new PopularDomain("Bánh vòng", "banh_vong", "Dầu ô liu, Dầu thực vật, Kalamata rỗ, Cà chua bi, Oregano tươi, Húng quế", 180000));
        foodStorage.add(new PopularDomain("Donut dâu tây", "donut_dau_tay", "là một loại bánh rán được làm từ bột mì và có hương vị matcha. Bánh có thể được phủ hoặc nhúng trong dâu tây ", 180000));
        foodStorage.add(new PopularDomain("Donut socola", "donut_socola", "Là một loại bánh rán được làm từ bột mì và có hương vị socola. Bánh có thể được phủ hoặc nhúng trong socola ", 180000));
        foodStorage.add(new PopularDomain("Donut sữa", "donut_sua", "Dầu ô liu, Dầu thực vật, Kalamata rỗ, Cà chua bi, Oregano tươi, Húng quế", 180000));
        foodStorage.add(new PopularDomain("Pizza nấm", "pizza_nam", "Dầu ô liu, Dầu thực vật, Kalamata rỗ, Cà chua bi, Oregano tươi, Húng quế", 180000));
        foodStorage.add(new PopularDomain("Pizza phô mai", "pizza_pho_mai", "Dầu ô liu, Dầu thực vật, Kalamata rỗ, Cà chua bi, Oregano tươi, Húng quế", 180000));
        foodStorage.add(new PopularDomain("Pizza rau củ", "pizza_rau_cu", "Dầu ô liu, Dầu thực vật, Kalamata rỗ, Cà chua bi, Oregano tươi, Húng quế", 180000));
        foodStorage.add(new PopularDomain("Pizza thịt xông khói", "pizza_thit_xong_khoi", "Dầu ô liu, Dầu thực vật, Kalamata rỗ, Cà chua bi, Oregano tươi, Húng quế", 180000));
        return foodStorage;
    }

    public ArrayList<PopularDomain> findFoodByTittle(String tittle, List<PopularDomain> food) {
        ArrayList<PopularDomain> result = new ArrayList<>();
        for (PopularDomain p : food) {
            if (p.getTitle().toLowerCase().contains(tittle.toLowerCase())) {
                result.add(p);
            }
        }
        return result;
    }

    public void spinnerInit() {
        String[] tittleValues = {"A->Z", "Z->A"};

        ArrayAdapter<String> tittleAdapter = new ArrayAdapter<String>(this,
                android.R.layout.simple_spinner_item, tittleValues);
        tittleAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);

        binding.tittleSpinner.setAdapter(tittleAdapter);

        String[] feeValues = {"Giá tăng dần", "Giá giảm dần"};

        ArrayAdapter<String> feeAdapter = new ArrayAdapter<String>(this,
                android.R.layout.simple_spinner_item, feeValues);
        feeAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);

        binding.feeSpinner.setAdapter(feeAdapter);
    }

    public void tittleSpinnerDrop() {
        binding.tittleSpinner.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
                String selectedValue = adapterView.getItemAtPosition(i).toString();
                switch (selectedValue) {
                    case "A->Z":
                        tittleSort(initList());
                        break;
                    case "Z->A":
                        tittleSortRevert(initList());
                        break;
                    default:
                        break;
                }
            }

            @Override
            public void onNothingSelected(AdapterView<?> parent) {
                // Do nothing
            }
        });
    }

    public void feeSpinnerDrop() {
        binding.feeSpinner.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
                String selectedValue = adapterView.getItemAtPosition(i).toString();
                switch (selectedValue) {
                    case "Giá tăng dần":
                        feeSort(initList());
                        break;
                    case "Giá giảm dần":
                        feeSortRevert(initList());
                        break;
                    default:
                        break;
                }
            }

            @Override
            public void onNothingSelected(AdapterView<?> parent) {
                // Do nothing
            }
        });
    }

    private void bottomNavigation() {
        binding.cartBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(new Intent(SearchActivity.this, CartListActivity.class));
            }
        });

        binding.homeBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(new Intent(SearchActivity.this, MainActivity.class));
            }
        });

        binding.profileBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(new Intent(SearchActivity.this, ProfileActivity.class));
            }
        });

        binding.settingBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(new Intent(SearchActivity.this, SettingActivity.class));
            }
        });

        binding.supportBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(new Intent(SearchActivity.this, SupportActivity.class));
            }
        });
    }
}