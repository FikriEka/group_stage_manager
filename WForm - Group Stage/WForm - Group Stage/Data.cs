using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WForm___Group_Stage
{
    public partial class Form1
    {
        BindingList<Team> TeamList;
        private void InitializeTeamList()
        {
            TeamList = new BindingList<Team> { };
            TeamList.AllowNew = true;
            TeamList.AllowRemove = true;

            TeamList.RaiseListChangedEvents = true;

            TeamList.AllowEdit = true;
        }
    }
}
