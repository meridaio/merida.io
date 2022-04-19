using System.Collections;

namespace MeridaIO.MarkdownTables.Models
{
    public class Table : IEnumerable<List<Cell>>
    {
        private readonly List<List<Cell>> _cells;

        public Table()
        {
            _cells = new List<List<Cell>>
            {
                new List<Cell>()
                {
                    new Cell(), new Cell()
                },
                new List<Cell>()
                {
                    new Cell(), new Cell()
                }
            };
        }

        public void AddRow()
        {
            var newRow = new List<Cell>();
            foreach (var _ in Enumerable.Range(0, _cells[0].Count))
                newRow.Add(new Cell());
            _cells.Add(newRow);
        }

        public void RemoveRow()
        {
            if (_cells.Count == 1)
                return;
            
            _cells.RemoveAt(_cells.Count - 1);
        }

        public void AddColumn()
        {
            foreach (var row in _cells)
            {
                row.Add(new Cell());
            }
        }

        public void RemoveColumn()
        {
            if (_cells[0].Count == 1)
                return;

            foreach (var row in _cells)
            {
                row.RemoveAt(row.Count - 1);
            }
        }

        public IEnumerator<List<Cell>> GetEnumerator()
        {
            return ((IEnumerable<List<Cell>>)_cells).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_cells).GetEnumerator();
        }

        public List<Cell> this[int i]
        {
            get { return _cells[i]; }
            set { _cells[i] = value; }
        }
    }
}
