using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demons2.Events
{
    abstract class Event
    {
        protected Event(Game g)
        {
            game = g;
        }

        readonly Game game;

        /// <summary>
        /// This method should contain the actual effects of this event, should it be unmodified by the event handler.
        /// </summary>
        abstract void runEvent();

        /// <summary>
        /// This method is a shortcut to have the associated game run this event
        /// </summary>
        public sealed void run()
        {
            game.eventManager.processEvent(this);
        }
    }


}
