public class MnistImg
{
    public int width; // 28
    public int height; // 28
    public byte[][] pixels; // 0 - 255 (white - black)
    public byte label; // 0 - 9
    public MnistImg(int width, int height, byte[][] pixels, byte label)
    {
        this.width = width;
        this.height = height;
        this.label = label;

        this.pixels = new byte[height][];
        for (int i = 0; i < this.pixels.Length; ++i)
            this.pixels[i] = new byte[width];

        for (int i = 0; i < height; ++i)
            for (int j = 0; j < width; ++j)
                this.pixels[i][j] = pixels[i][j];
    }

}