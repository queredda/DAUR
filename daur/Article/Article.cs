using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAUR.Article
    {
    internal class Article
    {
        private int _articleID;
        private string _datePublished;
        private string _articlePublisher;
        private string _typeOfArticle;
        private string _articleStatus;

        // Constructor to initialize the industry
        public Article(int articleID, string datePublished, string articlePublisher, string typeOfArticle, string articleStatus)
        {
            _articleID = articleID;
            _datePublished = datePublished;
            _articlePublisher = articlePublisher;
            _typeOfArticle = typeOfArticle;
            _articleStatus = articleStatus;
        }

        // Properties
        public int articleID
        {
            get { return _articleID; }
        }

        public string datePublished
        {
            get { return _datePublished; }
        }

        public string articlePublisher
        {
            get { return _articlePublisher; }
        }

        public string typeOfArticle
        {
            get { return _typeOfArticle; }
        }

        public string articleStatus
        {
            get { return _articleStatus; }
        }

        // Method for article verification by admin
        public void VerifyArticle(string adminDecision)
        {
            if (adminDecision.ToLower() == "approve")
            {
                _articleStatus = "Approved";
                Console.WriteLine($"Article {_articleID} has been approved by the admin.");
            }
            else if (adminDecision.ToLower() == "reject")
            {
                _articleStatus = "Rejected";
                Console.WriteLine($"Article {_articleID} has been rejected by the admin.");
            }
            else
            {
                Console.WriteLine("Invalid decision. Please choose either 'approve' or 'reject'.");
            }
        }

    }
}

