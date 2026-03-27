namespace Musify;

public class Album
{
    private string name;
    private string[] songNames;

    public Album(string name, string[] songNames)
    {
        this.name = name;
        this.songNames = songNames;
    }

    public void PlaySong(string songName)
    {
        for (int i = 0; i < songNames.Length; i++)
        {
            if (songNames[i] == songName)
            {
                Console.WriteLine("Reproduciendo: " + songName);
                return;
            }
        }
        Console.WriteLine("La canción '" + songName + "' no existe en el álbum.");
    }

    public void PlaySong(int index)
    {
        if (index >= songNames.Length)
        {
            Console.WriteLine("El índice " + index + " supera el tamaño del arreglo.");
            return;
        }

        Console.WriteLine("Reproduciendo: " + songNames[index]);
    }
}