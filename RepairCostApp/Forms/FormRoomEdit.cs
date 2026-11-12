using RepairCostApp.Repositories;
using RepairCostApp.Entities;
using RepairCostApp.Entities.Enums;
using System.ComponentModel;
using System;
using System.Windows.Forms;

namespace RepairCostApp.Forms
{
    public partial class FormRoomEdit : Form
    {
        private readonly IRoomRepository _roomRepository;
        private int? _roomId; 

        public FormRoomEdit(IRoomRepository roomRepository)
        {
            InitializeComponent();
            _roomRepository = roomRepository ?? throw new ArgumentNullException(nameof(roomRepository));

            comboBoxType.DataSource = Enum.GetValues(typeof(RoomType));
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int RoomId
        {
            set
            {
                _roomId = value;
                var room = _roomRepository.ReadRoomById(value);
                textBoxAddress.Text = room.Address;
                numericUpDownArea.Value = (decimal)room.Area;
                comboBoxType.SelectedItem = room.Type;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxAddress.Text))
                {
                    throw new Exception("Введите адрес помещения.");
                }

                var room = Room.CreateEntity(
                    _roomId ?? 0,
                    textBoxAddress.Text,
                    (double)numericUpDownArea.Value,
                    (RoomType)comboBoxType.SelectedItem!
                );

                if (_roomId.HasValue)
                {
                    _roomRepository.UpdateRoom(room);
                }
                else
                {
                    _roomRepository.CreateRoom(room);
                }

                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}