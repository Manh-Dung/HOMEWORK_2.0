import java.util.ArrayList;
import java.util.List;
import java.util.Random;

class elgamal {
    private int p = 2579;
    private int g = 2;
    private int a = 765;
    private String y1, y2;

    public elgamal() {

    }

    public List<elgamal> encrypt(String text) {
        Random random = new Random();
        int r = random.nextInt(1000);
        List<elgamal> list = new ArrayList<>();
        elgamal item = new elgamal();
        for (int i = 0; i < text.length(); i++) {
            char c = text.charAt(i);
            if (Character.isLetter(c)) {
                c = Character.toUpperCase(c);
                Double h = Math.pow(Double.valueOf(g), Double.valueOf(a)) % p;
                item.y1 = String.valueOf(Math.pow(Double.valueOf(a), Double.valueOf(r)) % p);
                item.y2 = String.valueOf((int) c * Math.pow(Double.valueOf(h), Double.valueOf(r)) % p);
            }
            list.add(item);
        }
        return list;
    }

}