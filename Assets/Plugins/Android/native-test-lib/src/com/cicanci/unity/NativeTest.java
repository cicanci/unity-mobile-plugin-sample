package com.cicanci.unity;

public class NativeTest {

    private int counter = 0;
    private String message = "Hello from Android";

    public int getCounter() {
      return ++this.counter;
    }

    public String getMessage() {
      return this.message + " " + this.counter;
    }

    public void setCounter(int counter) {
      this.counter = counter;
    }

    public void setMessage(String message) {
      this.message = message;
    }

}
