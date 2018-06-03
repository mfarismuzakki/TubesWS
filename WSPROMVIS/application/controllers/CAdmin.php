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
	        
	        $config['uri_segment']=3;
	        $this->pagination->initialize($config);
	        $data['pagination']=$this->pagination->create_links();
	        
	        
	        if($this->uri->segment(3)=="delete_success")
	            $data['message']="<div class='alert alert-success'>Data berhasil dihapus</div>";
	        else if($this->uri->segment(3)=="add_success")
	            $data['message']="<div class='alert alert-success'>Data berhasil disimpan</div>";
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

		public function CekAnggota($id, $endLink){
			$tmp = $this->MAdmin->GetData($endLink);
			

			$info=array(
		        'id_anggota'=>$id,
		        'nama_anggota'=>$tmp->nama_anggota,
		        'jenis_kelamin'=>$tmp->jenis_kelamin,
		        'tempat_lahir'=>$tmp->tempat_lahir,
		        'tanggal_lahir'=>$tmp->tanggal_lahir,
		        'notelepon'=>$tmp->notelepon,
		        'alamat'=>$tmp->alamat
		    );
		    return $info;
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
	            $data['message']="<div class='alert alert-success'>Data berhasil diupdate</div>";
	            
	            //tampilkan data anggota 
	            $data['anggota']=$this->CekAnggota($id, $uri.'/'.$id);
	            $this->template->display('admin/anggota/edit',$data);
	        }else{
	            $data['anggota']=$this->CekAnggota($id, $uri.'/'.$id);
	            $data['message']="";
	            $this->template->display('admin/anggota/edit',$data);
	        }
		}

		public function Pustakawan(){

			$this->Login_Check();

			$uri = "Pustakawan";

			$data['pustakawan']=$this->MAdmin->GetData($uri);
	        $data['title']="Data Pustakawan";
	        
	        $config['uri_segment']=3;
	        $this->pagination->initialize($config);
	        $data['pagination']=$this->pagination->create_links();
	        
	        
	        if($this->uri->segment(3)=="delete_success")
	            $data['message']="<div class='alert alert-success'>Data berhasil dihapus</div>";
	        else if($this->uri->segment(3)=="add_success")
	            $data['message']="<div class='alert alert-success'>Data berhasil disimpan</div>";
	        else
	            $data['message']='';
	            $this->template->display('admin/pustakawan/index',$data);	
		}

		function _set_rules_pustakawan(){
	        $this->form_validation->set_rules('id_pustakawan','ID','max_length[10]');
	        $this->form_validation->set_rules('nama_pustakawan','Nama','required|max_length[50]');
	        $this->form_validation->set_rules('jenis_kelamin','Jenis Kelamin','required|max_length[50]');
	        $this->form_validation->set_rules('tempat_lahir','Tempat Lahir','required|max_length[50]');
	        $this->form_validation->set_rules('tanggal_lahir','Tanggal Lahir','required');
	        $this->form_validation->set_rules('notelepon','No Telepon','required|max_length[20]');
	        $this->form_validation->set_rules('alamat','Alamat','required|max_length[100]');
	        $this->form_validation->set_error_delimiters("<div class='alert alert-danger'>","</div>");
	    }

		public function TambahPustakawan(){
			$uri = "Pustakawan";

			$data['title']="Tambah Data Pustakawan";
	        $this->_set_rules_pustakawan();

	        if($this->form_validation->run()==true){
	            $info=array(
	                'nama_pustakawan'=>$this->input->post('nama_pustakawan'),
	                'jenis_kelamin'=>$this->input->post('jenis_kelamin'),
	                'tempat_lahir'=>$this->input->post('tempat_lahir'),
	                'tanggal_lahir'=>$this->input->post('tanggal_lahir'),
	                'notelepon'=>$this->input->post('notelepon'),
	                'alamat'=>$this->input->post('alamat')
	            );
	            $this->MAdmin->TambahData($uri, $info);
	            redirect('CAdmin/Pustakawan/add_success');
	        }else{
	            $data['message']="";
	            $this->template->display('admin/pustakawan/tambah',$data);
	        }
		}

		public function CekPustakawan($id, $endLink){
			$tmp = $this->MAdmin->GetData($endLink);
			

			$info=array(
		        'id_pustakawan'=>$id,
		        'nama_pustakawan'=>$tmp->nama_pustakawan,
		        'jenis_kelamin'=>$tmp->jenis_kelamin,
		        'tempat_lahir'=>$tmp->tempat_lahir,
		        'tanggal_lahir'=>$tmp->tanggal_lahir,
		        'notelepon'=>$tmp->notelepon,
		        'alamat'=>$tmp->alamat
		    );
		    return $info;
		}

		public function EditPustakawan($id){
			$uri = "Pustakawan";

			$data['title']="Edit Data Pustakawan";

	        $this->_set_rules_pustakawan();

	        if($this->form_validation->run()==true){
	            $info=array(
	            	'id_pustakawan'=>$id,
	                'nama_pustakawan'=>$this->input->post('nama_pustakawan'),
	                'jenis_kelamin'=>$this->input->post('jenis_kelamin'),
	                'tempat_lahir'=>$this->input->post('tempat_lahir'),
	                'tanggal_lahir'=>$this->input->post('tanggal_lahir'),
	                'notelepon'=>$this->input->post('notelepon'),
	                'alamat'=>$this->input->post('alamat')
	            );
	            //update data pustakawan
	            $this->MAdmin->UpdateData($uri.'/'.$id, $info);
	            
	            //tampilkan pesan
	            $data['message']="<div class='alert alert-success'>Data Berhasil diupdate</div>";
	            
	            //tampilkan data anggota 
	            $data['pustakawan']=$this->CekPustakawan($id, $uri.'/'.$id);
	            $this->template->display('admin/pustakawan/edit',$data);
	        }else{
	            $data['pustakawan']=$this->CekPustakawan($id, $uri.'/'.$id);
	            $data['message']="";
	            $this->template->display('admin/pustakawan/edit',$data);
	        }
		}

		public function Penulis(){

			$this->Login_Check();

			$uri = "Penulis";

			$data['penulis']=$this->MAdmin->GetData($uri);
	        $data['title']="Data Penulis";
	        
	        $config['uri_segment']=3;
	        $this->pagination->initialize($config);
	        $data['pagination']=$this->pagination->create_links();
	        
	        
	        if($this->uri->segment(3)=="delete_success")
	            $data['message']="<div class='alert alert-success'>Data berhasil dihapus</div>";
	        else if($this->uri->segment(3)=="add_success")
	            $data['message']="<div class='alert alert-success'>Data berhasil disimpan</div>";
	        else
	            $data['message']='';
	            $this->template->display('admin/penulis/index',$data);	
		}

		function _set_rules_penulis(){
	        $this->form_validation->set_rules('id_penulis','ID','max_length[10]');
	        $this->form_validation->set_rules('nama_penulis','Nama','required|max_length[50]');
	        $this->form_validation->set_rules('tempat_lahir','Tempat Lahir','required|max_length[50]');
	        $this->form_validation->set_rules('tanggal_lahir','Tanggal Lahir','required');
	        $this->form_validation->set_rules('domisili','Domisili','required|max_length[100]');
	        $this->form_validation->set_error_delimiters("<div class='alert alert-danger'>","</div>");
	    }

		public function TambahPenulis(){
			$uri = "Penulis";

			$data['title']="Tambah Data Penulis";
	        $this->_set_rules_penulis();

	        if($this->form_validation->run()==true){
	            $info=array(
	                'nama_penulis'=>$this->input->post('nama_penulis'),
	                'tempat_lahir'=>$this->input->post('tempat_lahir'),
	                'tanggal_lahir'=>$this->input->post('tanggal_lahir'),
	                'domisili'=>$this->input->post('domisili')
	            );
	            $this->MAdmin->TambahData($uri, $info);
	            redirect('CAdmin/Penulis/add_success');
	        }else{
	            $data['message']="";
	            $this->template->display('admin/penulis/tambah',$data);
	        }
		}

		public function CekPenulis($id, $endLink){
			$tmp = $this->MAdmin->GetData($endLink);
			

			$info=array(
		        'id_penulis'=>$id,
		        'nama_penulis'=>$tmp->nama_penulis,
		        'tempat_lahir'=>$tmp->tempat_lahir,
		        'tanggal_lahir'=>$tmp->tanggal_lahir,
		        'domisili'=>$tmp->domisili
		    );
		    return $info;
		}

		public function EditPenulis($id){
			$uri = "Penulis";

			$data['title']="Edit Data Penulis";

	        $this->_set_rules_penulis();

	        if($this->form_validation->run()==true){
	            $info=array(
	            	'id_penulis'=>$id,
	                'nama_penulis'=>$this->input->post('nama_penulis'),
	                'tempat_lahir'=>$this->input->post('tempat_lahir'),
	                'tanggal_lahir'=>$this->input->post('tanggal_lahir'),
	                'domisili'=>$this->input->post('domisili')
	            );
	            //update data angggota
	            $this->MAdmin->UpdateData($uri.'/'.$id, $info);
	            
	            //tampilkan pesan
	            $data['message']="<div class='alert alert-success'>Data berhasil diupdate</div>";
	            
	            //tampilkan data anggota 
	            $data['penulis']=$this->CekPenulis($id, $uri.'/'.$id);
	            $this->template->display('admin/penulis/edit',$data);
	        }else{
	            $data['penulis']=$this->CekPenulis($id, $uri.'/'.$id);
	            $data['message']="";
	            $this->template->display('admin/penulis/edit',$data);
	        }
		}

		public function Penerbit(){

			$this->Login_Check();

			$uri = "Penerbit";

			$data['penerbit'] = $this->MAdmin->GetData($uri);
	        $data['title']="Data Penerbit";
	        
	        $config['uri_segment']=3;
	        $this->pagination->initialize($config);
	        $data['pagination']=$this->pagination->create_links();
	        
	        
	        if($this->uri->segment(3)=="delete_success")
	            $data['message']="<div class='alert alert-success'>Data berhasil dihapus</div>";
	        else if($this->uri->segment(3)=="add_success")
	            $data['message']="<div class='alert alert-success'>Data berhasil disimpan</div>";
	        else
	            $data['message']='';
	            $this->template->display('admin/penerbit/index',$data);	
		}

		function _set_rules_penerbit(){
	        $this->form_validation->set_rules('id_penerbit','ID','max_length[10]');
	        $this->form_validation->set_rules('nama_penerbit','Nama','required|max_length[50]');
	        $this->form_validation->set_rules('lokasipercetakan','Lokasi Percetakan','required|max_length[50]');
	        $this->form_validation->set_rules('notelepon','No Telepon','required|max_length[20]');
	        $this->form_validation->set_error_delimiters("<div class='alert alert-danger'>","</div>");
	    }

		public function TambahPenerbit(){
			$uri = "Penerbit";

			$data['title']="Tambah Data Penerbit";
	        $this->_set_rules_penerbit();

	        if($this->form_validation->run()==true){
	            $info=array(
	                'nama_penerbit'=>$this->input->post('nama_penerbit'),
	                'lokasipercetakan'=>$this->input->post('lokasipercetakan'),
	                'notelepon'=>$this->input->post('notelepon')
	            );
	            $this->MAdmin->TambahData($uri, $info);
	            redirect('CAdmin/Penerbit/add_success');
	        }else{
	            $data['message']="";
	            $this->template->display('admin/penerbit/tambah',$data);
	        }
		}

		public function CekPenerbit($id, $endLink){
			$tmp = $this->MAdmin->GetData($endLink);
			

			$info=array(
		        'id_penerbit'=>$id,
		        'nama_penerbit'=>$tmp->nama_penerbit,
		        'lokasipercetakan'=>$tmp->lokasi_percetakan,
		        'notelepon'=>$tmp->notelepon
		    );
		    return $info;
		}

		public function EditPenerbit($id){
			$uri = "Penerbit";

			$data['title']="Edit Data Penerbit";

	        $this->_set_rules_penerbit();

	        if($this->form_validation->run()==true){
	            $info=array(
	            	'nama_penerbit'=>$this->input->post('nama_penerbit'),
	                'lokasipercetakan'=>$this->input->post('lokasipercetakan'),
	                'notelepon'=>$this->input->post('notelepon')
	            );
	            //update data pustakawan
	            $this->MAdmin->UpdateData($uri.'/'.$id, $info);
	            
	            //tampilkan pesan
	            $data['message']="<div class='alert alert-success'>Data Berhasil diupdate</div>";
	            
	            //tampilkan data anggota 
	            $data['penerbit']=$this->CekPenerbit($id, $uri.'/GetByIdPenerbit/'.$id);
	            $this->template->display('admin/penerbit/edit',$data);
	        }else{
	            $data['penerbit']=$this->CekPenerbit($id, $uri.'/GetByIdPenerbit/'.$id);
	            $data['message']="";
	            $this->template->display('admin/penerbit/edit',$data);
	        }
		}

		public function Peminjaman(){

			$this->Login_Check();

			$query = "select peminjaman.id_peminjaman, peminjaman.tanggalpinjam, peminjaman.tanggalkembali, anggotaperpustakaan.nama_anggota, pustakawan.nama_pustakawan, detail_peminjaman.id_detail_peminjaman, detail_peminjaman.id_copy_buku, copy_buku.id_buku, judulbuku.judul_buku, penulis.nama_penulis from peminjaman join anggotaperpustakaan join pustakawan join detail_peminjaman join copy_buku join judulbuku join penulis where peminjaman.id_peminjaman=detail_peminjaman.id_peminjaman and peminjaman.id_anggota=anggotaperpustakaan.id_anggota and peminjaman.id_pustakawan=pustakawan.id_pustakawan and detail_peminjaman.id_copy_buku=copy_buku.id_copy_buku and copy_buku.id_buku=judulbuku.id_buku and judulbuku.id_penulis=penulis.id_penulis;";

			$data['peminjaman'] = $this->MAdmin->GetDataDB($query);
	        $data['title']="Data Peminjaman";
	        
	        $config['uri_segment']=3;
	        $this->pagination->initialize($config);
	        $data['pagination']=$this->pagination->create_links();
	        
	        
	        if($this->uri->segment(3)=="delete_success")
	            $data['message']="<div class='alert alert-success'>Data berhasil dihapus</div>";
	        else
	            $data['message']='';
	            $this->template->display('admin/peminjaman/index',$data);	
		}

		public function HapusPeminjaman(){
			$id=$this->input->post('id');
			/*
			$query2 = "select id_copy_buku from detail_peminjaman where id_detail_peminjaman=".$id.";";
			$tmp = $this->MAdmin->GetDataDB($query);

			$query3 = "select id_buku from copy_buku where id_copy_buku=".$tmp['id_copy_buku'].";";
			$tmp = $this->MAdmin->GetDataDB($query);

			$query3 = "select stok from stok_buku where id_buku=".$tmp['id_buku'].";";
			$tmp = $this->MAdmin->GetDataDB($query);
			$tmp['stok']++;

			$query4 = "update stok_buku set stok=".$tmp['stok']." where id_buku=".$tmp['id_buku'].";";
*/
			$query = "delete from detail_peminjaman where id_detail_peminjaman=".$id.";";
			$hapus = $this->MAdmin->GetDataDB($query);

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