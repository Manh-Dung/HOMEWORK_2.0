package com.example.tetrisgame.presenters;

public class GamePresenter {
    private GameView mGameView;
    private GameModel mGameModel;
    private GameStatus mGameStatus;

    public void setGameView(GameView gameView) {
        mGameView = gameView;
    }

    public void setGameModel(GameModel gameModel) {
        mGameModel = gameModel;
    }

    public void init(){
        mGameModel.init();
        mGameView.init(mGameModel.getGameSize());
        mGameModel.setGameOverListener(() -> setStatus(GameStatus.OVER));
    }

    private void setStatus(GameStatus status){
        if (mGameStatus == GameStatus.OVER || status == GameStatus.START){
            mGameModel.newGame();
        }
        mGameStatus = status;
        mGameView.setStatus(status);
    }
}
