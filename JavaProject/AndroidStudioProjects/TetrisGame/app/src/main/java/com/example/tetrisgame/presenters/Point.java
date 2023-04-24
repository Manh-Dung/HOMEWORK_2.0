package com.example.tetrisgame.presenters;

public class Point {
    public final int x, y;
    public boolean isFallingPoint;
    public PointType type;

    public Point(int x, int y) {
        this.x = x;
        this.y = y;
        this.type = PointType.EMPTY;
        this.isFallingPoint = false;
    }

    public Point(int x, int y, boolean isFallingPoint, PointType type) {
        this.x = x;
        this.y = y;
        this.isFallingPoint = isFallingPoint;
        this.type = type;
    }

    public boolean isStablePoint(){
        return !isFallingPoint && type == PointType.BOX;
    }
}
