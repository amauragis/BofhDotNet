using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BofhDotNet.IrcBotCommon;
using IrcDotNet;

namespace BofhDotNet
{
    class BofhBot : BasicIrcBot
    {

        private const string quitMessage = "RIP Me.";

        // bot stats
        private DateTime launchTime;
        private int numQuotesSinceLaunch;

        public BofhBot() : base()
        {
            this.launchTime = DateTime.UtcNow;
            this.numQuotesSinceLaunch = 0;
        }

        public override IrcRegistrationInfo RegistrationInfo => new IrcUserRegistrationInfo()
        {
            NickName = "bofhwits",
            UserName = "bofhwits",
            RealName = "bofhwits"
        };

        public override string QuitMessage => quitMessage;

        #region UnusedEvents
        protected override void OnClientConnect(IrcClient client)
        {
            //
        }

        protected override void OnClientDisconnect(IrcClient client)
        {
            //
        }

        protected override void OnClientRegistered(IrcClient client)
        {
            //
        }

        protected override void OnLocalUserJoinedChannel(IrcLocalUser localUser, IrcChannelEventArgs e)
        {
            //
        }

        protected override void OnLocalUserLeftChannel(IrcLocalUser localUser, IrcChannelEventArgs e)
        {
            //
        }

        protected override void OnLocalUserNoticeReceived(IrcLocalUser localUser, IrcMessageEventArgs e)
        {
            //
        }

        protected override void OnLocalUserMessageReceived(IrcLocalUser localUser, IrcMessageEventArgs e)
        {
            //
        }

        protected override void OnChannelUserJoined(IrcChannel channel, IrcChannelUserEventArgs e)
        {
            //
        }

        protected override void OnChannelUserLeft(IrcChannel channel, IrcChannelUserEventArgs e)
        {
            //
        }

        protected override void OnChannelNoticeReceived(IrcChannel channel, IrcMessageEventArgs e)
        {
            //
        }
        #endregion

        protected override void OnChannelMessageReceived(IrcChannel channel, IrcMessageEventArgs e)
        {
            var client = channel.Client;
            if (e.Source is IrcUser)
            {
                // TODO: keep log of recent chats?
            }
        }

        protected override void InitializeChatCommandProcessors()
        {
            base.InitializeChatCommandProcessors();

            this.ChatCommandProcessors.Add("buttes", ProcessChatCommandButtes);

            //this.ChatCommandProcessors.Add("talk", ProcessChatCommandTalk);
            //this.ChatCommandProcessors.Add("stats", ProcessChatCommandStats);
        }

        #region Chat Command Processors

        private void ProcessChatCommandButtes(IrcClient client, IIrcMessageSource source,
            IList<IIrcMessageTarget> targets, string command, IList<string> parameters)
        {
            client.LocalUser.SendNotice(targets, "donges.");
        }

        //private void ProcessChatCommandTalk(IrcClient client, IIrcMessageSource source,
        //    IList<IIrcMessageTarget> targets, string command, IList<string> parameters)
        //{
        //    // Send reply containing random message text (generated from Markov chain).
        //    int numSentences = -1;
        //    if (parameters.Count >= 1)
        //        numSentences = int.Parse(parameters[0]);
        //    string higlightNickName = null;
        //    if (parameters.Count >= 2)
        //        higlightNickName = parameters[1] + ": ";
        //    SendRandomMessage(client, GetDefaultReplyTarget(client, source, targets),
        //        higlightNickName, numSentences);
        //}

        //private void ProcessChatCommandStats(IrcClient client, IIrcMessageSource source,
        //    IList<IIrcMessageTarget> targets, string command, IList<string> parameters)
        //{
        //    // Send reply with bot statistics.
        //    var replyTargets = GetDefaultReplyTarget(client, source, targets);

        //    client.LocalUser.SendNotice(replyTargets, "Bot launch time: {0:f} ({1:g} ago)",
        //        this.launchTime,
        //        DateTime.Now - this.launchTime);
        //    client.LocalUser.SendNotice(replyTargets, "Number of training messages received: {0:#,#0} ({1:#,#0} words)",
        //        this.numTrainingMessagesReceived,
        //        this.numTrainingWordsReceived);
        //    client.LocalUser.SendNotice(replyTargets, "Number of unique words in vocabulary: {0:#,#0}",
        //        this.markovChain.Nodes.Count);
        //}

        #endregion

        protected override void InitializeCommandProcessors()
        {
            base.InitializeCommandProcessors();
        }

        #region Command Processors

        //

        #endregion
    }
}
