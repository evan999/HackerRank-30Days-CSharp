using System;
					
public class Program
{
	public static void Main()
	{
		// Console.WriteLine("Hello World");
		GameBoard board  = new GameBoard(3, 3);
		//GameBoard.drawBoard();
		board.drawBoard();
	}
}

public class GameBoard
{
	public int height {get; set;}
	public int width {get; set;}
	
	public GameBoard(int height, int width)
	{
		this.height = height;
		this.width = width;
	}
	
	public void drawBoard()
		// public static void drawBoard(int height, int width)
	{
		for (int row = 0; row < this.height; row++)
		{
			for (int cellPart = 0; cellPart < 3; cellPart++)
			{
				for (int column = 0; column < this.width; column++)
				{
					switch (cellPart) // bool toggle = false;
					{
						case 1:
							Console.Write("| |");
							break;
						case 0:
						case 2:
							Console.Write("+-+");
							break;		

					}
				}
				Console.WriteLine("");
			}
			
			
			
		}
	}
}

//	+-+
//	| |
//	+-+