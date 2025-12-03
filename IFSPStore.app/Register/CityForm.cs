using IFSPStore.app.Base;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validatorrs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFSPStore.app.Register
{
    public partial class CityForm : BaseForm
    {
        private IBaseService<City> _cityService;
        private List<City> cities;
        public CityForm(IBaseService<City> cityService)
        {
            _cityService = cityService;
            InitializeComponent();
        }
        
         private void PreencheObjeto(City city)
        {
            city.Name = txtName.Text;
            city.State = cboState.Text;
        }

        protected override void Save()
        {
            try{
                if (IsEditMode){
                    if(int.TryParse(txtId.Text, out var id)){
                        var city = _cityService.GetById<City>(id);
                        PreencheObjeto(city);
                        city = _cityService.Update<City, City, CityValidator>(city);
                    }
                }
                else{
                    var city = new City();
                    PreencheObjeto (city);
                    _cityService.Add<City, City, CityValidator>(city); 

                }
                tabControlRegister.SelectedIndex = 1;
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message, @"IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try{
                _cityService.Delete(id);
            }catch (Exception ex){
                MessageBox.Show(ex.Message, @"IFSP Store",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            cities = _cityService.Get<City>().ToList(); 
            dataGridViewList.DataSource = cities;
            dataGridViewList.Columns["Name"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            txtId.Text = record?.Cells["Id"].Value.ToString();
            txtName.Text = record?.Cells["Name"].Value.ToString();
            cboState.Text = record?.Cells["State"].Value.ToString();
        }       

    }
}
