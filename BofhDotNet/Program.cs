using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BofhDotNet.IrcBotCommon;

namespace BofhDotNet
{
    class Program
    {
        static void Main(string[] args)
        {

            IrcBot bot = null;
            
            // TODO: Parse command line arguments.

            // TODO: Read in configuration

            try
            {
                // create a BofhBot
                bot = new BofhBot();

                // start it up
                bot.Run();
            }
#if !DEBUG
            catch(Exception ex)
            {
                ConsoleUtilities.WriteError("Fatal: " + ex.Message);
            }
#endif
            finally
            {
                bot?.Dispose();
            }
        }
    }
}
