using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topics.Radical.ComponentModel.Messaging;
using Topics.Radical.Presentation.OpenChildWindow;
using Topics.Radical.Windows.Presentation.ComponentModel;
using Topics.Radical.Windows.Presentation.Messaging;

namespace Topics.Radical.Messaging.Handlers
{
    class OpenChildWindowSampleMessageHandler : AbstractMessageHandler<OpenChildWindowSampleMessage>, INeedSafeSubscription
    {
        private readonly IViewResolver viewResolver;

        public OpenChildWindowSampleMessageHandler( IViewResolver viewResolver )
        {
            this.viewResolver = viewResolver;
        }

        public override void Handle( object sender, OpenChildWindowSampleMessage message )
        {
            var view = this.viewResolver.GetView<ChildView>();
            if (message.AsDialog)
            {
                view.ShowDialog();
            }
            else
            {
                view.Show();
            }
        }
    }
}
