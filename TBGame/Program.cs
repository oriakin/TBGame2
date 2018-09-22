using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBGame
{
	class Program
	{
		static void Main(string[] args){
			welcomeMessage();
			Console.ReadKey();
		}
		
		static void nLine(){
			Console.WriteLine();
		}

		static void welcomeMessage() {

			// Initialize local variables
			int cursorPosX = 60;
			int cursorPosY = 0;

			Console.Title = "Pontus Text Based Game v.1";
			Console.SetWindowSize(160, 40); //Sets console window-size to 160 x 40 columns for better gaming experience
			Console.SetBufferSize(160, 40); //Sets buffersize to same as the console size in order to remove scrolling bar
			Console.CursorVisible = false;
			//Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.SetCursorPosition(cursorPosX, cursorPosY);
			Console.WriteLine
				("###########################################"); Console.SetCursorPosition(cursorPosX, cursorPosY+=1); Console.WriteLine
				("#                                         #"); Console.SetCursorPosition(cursorPosX, cursorPosY+=1); Console.WriteLine
				("#                                         #"); Console.SetCursorPosition(cursorPosX, cursorPosY+=1); Console.WriteLine
				("#                                         #"); Console.SetCursorPosition(cursorPosX, cursorPosY+=1); Console.WriteLine
				("#                                         #"); Console.SetCursorPosition(cursorPosX, cursorPosY+=1); Console.WriteLine
				("#                                         #"); Console.SetCursorPosition(cursorPosX, cursorPosY+=1); Console.WriteLine
				("#                                         #"); Console.SetCursorPosition(cursorPosX, cursorPosY+=1); Console.WriteLine
				("#                                         #"); Console.SetCursorPosition(cursorPosX, cursorPosY+=1); Console.WriteLine
				("#                                         #"); Console.SetCursorPosition(cursorPosX, cursorPosY+=1); Console.WriteLine
				("###########################################");
		}
	}
}
