package com.example.tetrisgame.presenters;

public interface GameModel {
    int FPS = 60;
    int SPEED = 25;
    void init();
    int getGameSize();
    void newGame();
    void statusGame(PresenterObserver<Point[][]> onDrawListener);
    void pauseGame();
    void turn(GameTurn turn);
    void setGameOverListener(PresenterCompletableObserver onGameOverListener);
    void setScoreUpdatedListener(PresenterObserver<Integer> onScoreUpdatedListener);
}
