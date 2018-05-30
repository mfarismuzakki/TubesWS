<?php
class Anggota extends CI_Controller{
    private $limit=20;
    
    function __construct(){
        parent::__construct();
        $this->load->library(array('template','pagination','form_validation','upload'));
        $this->load->model('m_anggota');
    }
    
    function index($offset=0,$order_column='nama_anggota',$order_type='asc'){
        if(empty($offset)) $offset=0;
        if(empty($order_column)) $order_column='nama_anggota';
        if(empty($order_type)) $order_type='asc';
        
        //load data
        $data['anggota']=$this->m_anggota->semua($this->limit,$offset,$order_column,$order_type)->result();
        $data['title']="Data Anggota";
        
        $config['base_url']=site_url('anggota/index/');
        $config['total_rows']=$this->m_anggota->jumlah();
        $config['per_page']=$this->limit;
        $config['uri_segment']=3;
        $this->pagination->initialize($config);
        $data['pagination']=$this->pagination->create_links();
        
        
        if($this->uri->segment(3)=="delete_success")
            $data['message']="<div class='alert alert-success'>Data berhasil dihapus</div>";
        else if($this->uri->segment(3)=="add_success")
            $data['message']="<div class='alert alert-success'>Data Berhasil disimpan</div>";
        else
            $data['message']='';
            $this->template->display('anggota/index',$data);
    }
    
    
    function edit($id){
        $data['title']="Edit Data Anggota";
        $this->_set_rules();
        if($this->form_validation->run()==true){
            $info=array(
                'nama_anggota'=>$this->input->post('nama_anggota'),
                'jenis_kelamin'=>$this->input->post('jenis_kelamin'),
                'tempat_lahir'=>$this->input->post('tempat_lahir'),
                'tanggal_lahir'=>$this->input->post('tanggal_lahir'),
                'notelepon'=>$this->input->post('notelepon'),
                'alamat'=>$this->input->post('alamat')
            );
            //update data angggota
            $this->m_anggota->update($id,$info);
            
            //tampilkan pesan
            $data['message']="<div class='alert alert-success'>Data Berhasil diupdate</div>";
            
            //tampilkan data anggota 
            $data['anggota']=$this->m_anggota->cek($id)->row_array();
            $this->template->display('anggota/edit',$data);
        }else{
            $data['anggota']=$this->m_anggota->cek($id)->row_array();
            $data['message']="";
            $this->template->display('anggota/edit',$data);
        }
    }
    
    
    function tambah(){
        $data['title']="Tambah Data Anggota";
        $this->_set_rules();
        if($this->form_validation->run()==true){
            $id=$this->input->post('id_anggota');
            $cek=$this->m_anggota->cek($id);
            if($cek->num_rows()>0){
                $data['message']="<div class='alert alert-warning'>ID sudah digunakan</div>";
                $this->template->display('anggota/tambah',$data);
            }else{                
                $info=array(
                    'nama_anggota'=>$this->input->post('nama_anggota'),
                    'jenis_kelamin'=>$this->input->post('jenis_kelamin'),
                    'tempat_lahir'=>$this->input->post('tempat_lahir'),
                    'tanggal_lahir'=>$this->input->post('tanggal_lahir'),
                    'notelepon'=>$this->input->post('notelepon'),
                    'alamat'=>$this->input->post('alamat')
                );
                $this->m_anggota->simpan($info);
                redirect('anggota/index/add_success');
            }
        }else{
            $data['message']="";
            $this->template->display('anggota/tambah',$data);
        }
    }
    
    
    function hapus(){
        $id=$this->input->post('id');
       
        $this->m_anggota->hapus($id);
    }
    
    function cari(){
        $data['title']="Pencarian";
        $cari=$this->input->post('cari');
        $cek=$this->m_anggota->cari($cari);
        if($cek->num_rows()>0){
            $data['message']="";
            $data['anggota']=$cek->result();
            $this->template->display('anggota/cari',$data);
        }else{
            $data['message']="<div class='alert alert-success'>Data tidak ditemukan</div>";
            $data['anggota']=$cek->result();
            $this->template->display('anggota/cari',$data);
        }
    }
    
    function _set_rules(){
        $this->form_validation->set_rules('id_anggota','ID','max_length[10]');
        $this->form_validation->set_rules('nama_anggota','Nama','required|max_length[50]');
        $this->form_validation->set_rules('jenis_kelamin','Jenis Kelamin','required|max_length[50]');
        $this->form_validation->set_rules('tempat_lahir','Tempat Lahir','required|max_length[50]');
        $this->form_validation->set_rules('tanggal_lahir','Tanggal Lahir','required');
        $this->form_validation->set_rules('notelepon','No Telepon','required|max_length[20]');
        $this->form_validation->set_rules('alamat','Alamat','required|max_length[100]');
        $this->form_validation->set_error_delimiters("<div class='alert alert-danger'>","</div>");
    }
}
