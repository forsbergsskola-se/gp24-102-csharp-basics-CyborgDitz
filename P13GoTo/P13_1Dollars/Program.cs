// // See https://aka.ms/new-console-template for more information
Console.WriteLine("How many dollahs you want yo?");
var dollahs = Convert.ToInt32(Console.ReadLine());
int i = 0;
dol:
if (i < dollahs) 
{
 Console.Write("$");
 i++;
 goto dol;
}
Console.WriteLine(); //linebreaker
Console.WriteLine("Thats a lot of dollah!");

// for loop but not go to
 // string mon = "$";
 // for (int i = 0; i < dollahs; i++) {
 // Console.Write(mon);
 //
 // }
 //














// switch (dollahs)
// { case 1:
//         goto one;
//         break;
// }
// case 2: goto two;
//      break;
//  case 3: goto three;
//      break;
//  case 4: goto four;
//      break;
//     case 5: goto five;
//         break;
//      case 6: goto six;
//          break;
//          case 7: goto seven;
//              break;
//              case 8: goto eight;
//                  break;
//                  case 9: goto nine;
//                      break;
//                      case 10: goto ten;
//                          break;
// }
// // Console.WriteLine($"Here's your Dollars: " + "a");
// one:
// Console.WriteLine("$");
// two:
// Console.WriteLine("$$");
// three:
// Console.WriteLine("$$$");
// four:
// Console.WriteLine("$$$$");
// five:
// Console.WriteLine("$$$$$");
// six:
// Console.WriteLine("$$$$$$");
// seven:
// Console.WriteLine("$$$$$$$");
// eight:
// Console.WriteLine("$$$$$$$$");
// nine:
// Console.WriteLine("$$$$$$$$$");
// ten:
// Console.WriteLine("$$$$$$$$$$");