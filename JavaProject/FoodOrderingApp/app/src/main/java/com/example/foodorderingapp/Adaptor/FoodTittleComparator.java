package com.example.foodorderingapp.Adaptor;

import com.example.foodorderingapp.Domain.PopularDomain;

import java.util.Comparator;

public class FoodTittleComparator implements Comparator<PopularDomain> {

    @Override
    public int compare(PopularDomain popularDomain, PopularDomain t1) {
        return popularDomain.getTitle().compareTo(t1.getTitle());
    }

    @Override
    public Comparator<PopularDomain> reversed() {
        return Comparator.super.reversed();
    }
}
