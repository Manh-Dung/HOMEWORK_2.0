package com.example.foodorderingapp.Domain;

public class NotificationDomain {
    private String notiID;
    private String userID;
    private String notiType;
    private String isRead;
    private String time;

    public NotificationDomain() {
    }

    public NotificationDomain(String notiID, String userID, String time, String notiType) {
        this.notiID = notiID;
        this.userID = userID;
        this.notiType = notiType;
        this.isRead = "false";
        this.time = time;
    }

    public String getNotiID() {
        return notiID;
    }

    public void setNotiID(String notiID) {
        this.notiID = notiID;
    }

    public String getUserID() {
        return userID;
    }

    public void setUserID(String userID) {
        this.userID = userID;
    }

    public String getNotiType() {
        return notiType;
    }

    public void setNotiType(String notiType) {
        this.notiType = notiType;
    }

    public String getIsRead() {
        return isRead;
    }

    public void setIsRead(String isRead) {
        this.isRead = isRead;
    }

    public String getTime() {
        return time;
    }

    public void setTime(String time) {
        this.time = time;
    }


}
