using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Newtonsoft.Json;

namespace ToDoApp.Models
{
    class ToDoModel : INotifyPropertyChanged
    {
        [JsonProperty(PropertyName = "creationDate")]
        public DateTime CreationDate { get; set; } = DateTime.Now;
        private bool _isDone;
        
        [JsonProperty(PropertyName = "isDone")]
        public bool IsDone
        {
            get { return _isDone; }
            set 
            {
                if (_isDone == value)
                {
                    return;
                }
                _isDone = value;
                OnPropertyChanged("IsDone");
            }
        }

        private string _text;

        [JsonProperty(PropertyName = "text")]
        public string Text
        {
            get { return _text; }
            set 
            {
                if (_text == value)
                {
                    return;
                }
                _text = value;
                OnPropertyChanged("Text");
            }
        }

        //для того, чтобы отслеживать измерения в списке дел, а именно изменение поля 'ToDo', нам необходимо реализовать интерфейс INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
