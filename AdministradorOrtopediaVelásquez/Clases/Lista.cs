using System.Collections;
using System.Collections.Generic;

namespace Desafio.Clases
{

    /* Clase tipo lista implemetando Pilas e IEnumerable del tipo generico */

    class Lista<T> : IEnumerable<T>
    {

        protected class node
        {
            private T data { get; set; }

            public node next { get; set; }

            public node(T t)  //Non-generic
            {
                next = null;
                data = t;
            }
            public node() { } //Default Constructor

            public T Value
            {
                get { return data; }
                set { data = value; }
            }
        }

        private node top;
        public int Count { get; private set; } = 0;

        public Lista(T t) {
            top = new node(t);
        }

        public Lista(T[] _array) {
            for (int i = 0; i < _array.Length; i++) {
                this.Push(_array[i]);
            }
        }

        public Lista() { }

        public static implicit operator Lista<T>(T[] obj)
        {
            return new Lista<T>(obj);
        }

        public void Push(T t)
        { //Inserta un elemento al principio de la fila

            if (top == null) { //Si es el primer elemento next es nulo
                top = new node(t);

            } else { //Si no top sera el next del ultimo elemento añadido
                node _aux = top;

                top = new node()
                {
                    Value = t,
                    next = _aux
                };
            }

            Count++;
        }

        public void Push(T _x, int _index) //Inserta un elemento el posicion especificada
        {
            Lista<T> _temp = new Lista<T>();

            if (Count == 0)
            {
                top = new node()
                {
                    Value = _x,
                    next = null
                };
            }
            else
            {
                int _ = Count;

                while (top.next != null)
                {
                    if (_ == _index + 1)
                    {
                        node _aux = top;
                        node _next = top.next;

                        _aux.next = new node()
                        {
                            Value = _x,
                            next = _next
                        };
                        while (_temp.top != null)
                        {
                            this.Push(_temp.top.Value);
                            _temp.top = _temp.top.next;
                        }
                        Count++;
                        break;
                    }
                    else
                    {
                        _temp.Push(top.Value);
                        top = top.next;
                        Count--;
                        _--;
                    }

                }
            }
        } //Ubica dentro de la posicion especificada

        public T Peek(int _index = -1) //Retorna un elemento especifico de la lista, Si no existe retorna null
        {
            if (_index == -1) { return top.Value; }

            node _temp = top;
            int _ = Count;
            while (_temp.next != null)
            {

                if (_ == _index)
                {
                    return _temp.Value;
                }
                else
                {
                    _--;
                    _temp = _temp.next;
                }
            }
            return default(T);
        }

        public bool Remove(int _index = -1)//Elimina el nodo especificado, Si no recibe nada elimimina el ultimo nodo, Si esta vacia retorna false
        { 
            if (_index == -1) { top = top.next; return true; }

            Lista<T> _temp = new Lista<T>();

            while (top.next != null)
            {
                if (Count == _index + 1)
                {
                    node _aux = top;
                    node _next = top.next.next;

                    _aux.next = _next;
                    while (_temp.top != null)
                    {
                        this.Push(_temp.top.Value);
                        _temp.top = _temp.top.next;
                    }
                    Count--;
                    return true;
                }
                else
                {
                    _temp.Push(top.Value);
                    Count--;
                    top = top.next;
                }
            }
            return false;
        }

        public bool Replace(T _x, int _index) {
            Lista<T> _temp = new Lista<T>();

            while (top.next != null)
            {
                if (Count == _index - 1)
                {
                    node _aux = top;
                    node _next = top.next.next;

                    _aux.next = _next;
                    while (_temp.top != null)
                    {
                        this.Push(_temp.top.Value);
                        _temp.top = _temp.top.next;
                    }
                    Count--;
                    return true;
                }
                else
                {
                    _temp.Push(top.Value);
                    Count--;
                    top = top.next;
                }
            }
            return false;
        } //Useless
        public void Truncate() //Reinicializa la lista
        {
            top = null; //Nullea el elemento principal
            Count = 0; //Vuelte su cuanta a 0
        }

        //El uso de estas interfaces permite la implementacion de foreach
        public IEnumerator<T> GetEnumerator()
        {
            node current = top;
            while (current != null)
            {
                yield return current.Value;
                current = current.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }//Clase
}//NameSpace
