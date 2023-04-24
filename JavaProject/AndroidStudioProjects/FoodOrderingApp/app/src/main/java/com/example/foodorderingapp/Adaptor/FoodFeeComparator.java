package com.example.foodorderingapp.Adaptor;

import com.example.foodorderingapp.Domain.PopularDomain;

import java.util.Comparator;

public class FoodFeeComparator implements Comparator<PopularDomain>{
    @Override
    public int compare(PopularDomain popularDomain1, PopularDomain popularDomain2) {
        return popularDomain1.getFee() - popularDomain2.getFee();
    }

    public Comparator<PopularDomain> reversed() {
        return Comparator.super.reversed();
    }
}
