<?php 
	
	defined('BASEPATH') OR exit('No direct script access allowed');
	
	class CAdmin extends CI_Controller{

		
		//kosntruktor
		public function __construct(){
			parent:: __construct();
			$this->load->library(array('template','pagination','form_validation','upload'));
			$this->load->model('MAdmin');
		}

		//cek status login
		function Login_Check(){

			if(!$this->session->loged_in && $this->session->username == "admin"){
				redirect('CAdmin');
			}
		} 

		//index
		public function index(){
			$this->Login_Check();

			$data['title']="Home";
        
       		$this->template->display('admin/dashboard',$data);

		}

		public function Anggota(){

			$this->Login_Check();

			$uri = "AnggotaPerpustakaan";

			$data['anggota']=$this->MAdmin->GetData($uri);
	        $data['title']="Data Anggota";
	        
	        $config['base_url']=site_url('anggota/index/');
	        $config['uri_segment']=3;
	        $this->pagination->initialize($config);
	        $data['pagination']=$this->pagination->create_links();
	        
	        
	        if($this->uri->segment(3)=="delete_success")
	            $data['message']="<div class='alert alert-success'>Data berhasil dihapus</div>";
	        else if($this->uri->segment(3)=="add_success")
	            $data['message']="<div class='alert alert-success'>Data Berhasil disimpan</div>";
	        else
	            $data['message']='';
	            $this->template->display('admin/anggota/index',$data);	
		}

		function _set_rules_anggota(){
	        $this->form_validation->set_rules('id_anggota','ID','max_length[10]');
	        $this->form_validation->set_rules('nama_anggota','Nama','required|max_length[50]');
	        $this->form_validation->set_rules('jenis_kelamin','Jenis Kelamin','required|max_length[50]');
	        $this->form_validation->set_rules('tempat_lahir','Tempat Lahir','required|max_length[50]');
	        $this->form_validation->set_rules('tanggal_lahir','Tanggal Lahir','required');
	        $this->form_validation->set_rules('notelepon','No Telepon','required|max_length[20]');
	        $this->form_validation->set_rules('alamat','Alamat','required|max_length[100]');
	        $this->form_validation->set_error_delimiters("<div class='alert alert-danger'>","</div>");
	    }

		public function TambahAnggota(){
			$uri = "AnggotaPerpustakaan";

			$data['title']="Tambah Data Anggota";
	        $this->_set_rules_anggota();

	        if($this->form_validation->run()==true){
	            $info=array(
	                'nama_anggota'=>$this->input->post('nama_anggota'),
	                'jenis_kelamin'=>$this->input->post('jenis_kelamin'),
	                'tempat_lahir'=>$this->input->post('tempat_lahir'),
	                'tanggal_lahir'=>$this->input->post('tanggal_lahir'),
	                'notelepon'=>$this->input->post('notelepon'),
	                'alamat'=>$this->input->post('alamat')
	            );
	            $this->MAdmin->TambahData($uri, $info);
	            redirect('CAdmin/Anggota/add_success');
	        }else{
	            $data['message']="";
	            $this->template->display('admin/anggota/tambah',$data);
	        }
		}

		public function EditAnggota($id){
			$uri = "AnggotaPerpustakaan";

			$data['title']="Edit Data Anggota";

	        $this->_set_rules_anggota();

	        if($this->form_validation->run()==true){
	            $info=array(
	            	'id_anggota'=>$id,
	                'nama_anggota'=>$this->input->post('nama_anggota'),
	                'jenis_kelamin'=>$this->input->post('jenis_kelamin'),
	                'tempat_lahir'=>$this->input->post('tempat_lahir'),
	                'tanggal_lahir'=>$this->input->post('tanggal_lahir'),
	                'notelepon'=>$this->input->post('notelepon'),
	                'alamat'=>$this->input->post('alamat')
	            );
	            //update data angggota
	            $this->MAdmin->UpdateData($uri.'/'.$id, $info);
	            
	            //tampilkan pesan
	            $data['message']="<div class='alert alert-success'>Data Berhasil diupdate</div>";
	            
	            //tampilkan data anggota 
	            $data['anggota']=$this->MAdmin->CekData($id, $uri.'/'.$id);
	            $this->template->display('admin/anggota/edit',$data);
	        }else{
	            $data['anggota']=$this->MAdmin->CekData($id, $uri.'/'.$id);
	            $data['message']="";
	            $this->template->display('admin/anggota/edit',$data);
	        }
		}

		public function Hapus($endLink){
			$id=$this->input->post('id');
			$this->MAdmin->DeleteData($endLink.'/'.$id);
		}


		//logut
		public function Logout(){

			$this->session->sess_destroy();
			redirect('UserHome');
		}


	}

 ?>