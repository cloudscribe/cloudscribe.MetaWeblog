using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cloudscribe.MetaWeblog
{
    public class MetaWeblogSecurityResult
    {
        public MetaWeblogSecurityResult(
            string displayName,
            string blogId,
            bool isAuthenticated, 
            bool canEdit)
        {
            this.displayName = displayName;
            this.blogId = blogId;
            this.isAuthenticated = isAuthenticated;
            this.canEdit = canEdit;
        }

        private string displayName = string.Empty;
        private string blogId = string.Empty;
        private bool isAuthenticated = false;
        private bool canEdit = false;

        public string DisplayName
        {
            get { return displayName; }
        }

        public string BlogId
        {
            get { return blogId; }
        }


        public bool IsAuthenticated
        {
            get { return isAuthenticated; }
        }

        public bool CanEdit
        {
            get { return canEdit; }
        }
    }
}
