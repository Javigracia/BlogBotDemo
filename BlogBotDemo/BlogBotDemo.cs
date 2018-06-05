using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System.Threading.Tasks;

namespace BlogBotDemo
{
    public class BlogBotDemo : IBot
    {
        public async Task OnTurn(ITurnContext turnContext)
        {
            if (turnContext.Activity.Type is ActivityTypes.Message)
            {
                string userInput = turnContext.Activity.Text;
                await turnContext.SendActivity($"Has escrito {userInput}");
            }
        }
    }
}
