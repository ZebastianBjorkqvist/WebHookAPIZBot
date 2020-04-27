using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace WebHookAPIZBot.Controllers
{
    [ApiController]
    [Route("~/")]
    public class WebhookReciveverController : ControllerBase
    {
        private readonly ILogger _logger;
        public WebhookReciveverController(ILogger<WebhookReciveverController> logger)
        {
            _logger = logger;
            _logger.LogInformation("Created");
            
        }

        [HttpPost("recieve")]
        public void Recieve([FromBody]Github response)
        {

            if (response.Sender.Name == "ZebastianBjorkqvist")
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "/home/zebbe/sambashare/ZbotGit/ClonePublishRunZBot.sh";
                psi.UseShellExecute = false;
                psi.RedirectStandardOutput = true;

                Process p = Process.Start(psi);
                string strOutput = p.StandardOutput.ReadToEnd();
                p.WaitForExit();
                Console.WriteLine(strOutput);
            }
        }
    }
}
