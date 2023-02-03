using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula131_ex_composicao_02.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set;} = new List<Comment>();

        public Post() { 
        
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment) {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment) {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            // "StringBuilder" é melhor por que eu não sei quantos comentários vai ter, ai pra não pesar muito a aplicação, eu uso o "StringBuilder".
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments");
            foreach(Comment c in Comments) {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
