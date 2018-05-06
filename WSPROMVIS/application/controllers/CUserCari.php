<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class CUserCari extends CI_Controller {

		var $current = array(
		'buku' => null,
		'penulis' => null,
		'penerbit' => null,
		'kategori' => null,
		'bahasa' => null,
		'daftar_peminjaman' => null,
		'waktu_pengembalian' => null,
		'daftar_transaksi' => null
		);

		var $penampung = array();

	//konstruktor
	function __construct(){
		parent::__construct();
		$this->load->helper('array');
		//load data
		$this->load->model('MBuku');
	}
		
	function Login_Check(){

		if(!$this->session->loged_in){
			redirect('UserHome');
		}

	} 

	//index
	public function index(){
		$this->Login_Check();

		$active['status'] = $this->current;
		$this->load->view('user/VUheader');
		$this->load->view('user/VUsidebar',$active);
	
	}

	//view penulis
	public function Penulis(){

		$this->Login_Check();

		$active['status'] = $this->current;
		$active['status']['penulis'] = 'active';

		$this->load->view('user/VUheader');
		$this->load->view('user/VUsidebar',$active);
		$this->load->view('user/VUcaripenulis');		
	}

	//pencarian penulis
	public function CariPenulis(){
		//pencarian berdasarkan
		$berdasarkan = $this->input->post('berdasarkan');
		$key = $this->input->post('cari');



		//memasukan data kedalam array
		$data['buku'] = $this->MBuku->CariPenulis($berdasarkan,$key);

		//load tampilan
		$this->Penulis();
		$this->load->view('user/VUhasilcaripenulis',$data);	
	}

	public function Penerbit(){

		$this->Login_Check();

		$active['status'] = $this->current;
		$active['status']['penerbit'] = 'active';

		$this->load->view('user/VUheader');
		$this->load->view('user/VUsidebar',$active);
		$this->load->view('user/VUcaripenerbit');
	}

	public function CariPenerbit(){

		//pencarian berdasarkan
		$berdasarkan = $this->input->post('berdasarkan');
		$key = $this->input->post('cari');

		//memasukan data kedalam array
		$data['buku'] = $this->MBuku->CariPenerbit($berdasarkan,$key);

		//load tampilan
		$this->Penerbit();
		$this->load->view('user/VUhasilcaripenerbit',$data);

	}

	public function Bahasa(){

		$this->Login_Check();

		$active['status'] = $this->current;
		$active['status']['bahasa'] = 'active';

		$this->load->view('user/VUheader');
		$this->load->view('user/VUsidebar',$active);
		$this->load->view('user/VUcaribahasa');
	}

	public function CariBahasa(){

		//pencarian berdasarkan
		$berdasarkan = $this->input->post('berdasarkan');
		$key = $this->input->post('cari');

		//memasukan data kedalam array
		$data['buku'] = $this->MBuku->CariBahasa($berdasarkan,$key);

		//load tampilan
		$this->Bahasa();
		$this->load->view('user/VUhasilcaribahasa',$data);

	}


	public function Kategori(){

		$this->Login_Check();

		$active['status'] = $this->current;
		$active['status']['kategori'] = 'active';

		$this->load->view('user/VUheader');
		$this->load->view('user/VUsidebar',$active);
		$this->load->view('user/VUcarikategori');
	}

	public function CariKategori(){

		//pencarian berdasarkan
		$berdasarkan = $this->input->post('berdasarkan');
		$key = $this->input->post('cari');

		//memasukan data kedalam array
		$data['buku'] = $this->MBuku->CariKategori($berdasarkan,$key);

		//load tampilan
		$this->Kategori();
		$this->load->view('user/VUhasilcarikategori',$data);
	}

	public function Buku(){

		$this->Login_Check();

		$active['status'] = $this->current;
		$active['status']['buku'] = 'active';

		$this->load->view('user/VUheader');
		$this->load->view('user/VUsidebar',$active);
		$this->load->view('user/VUcaribuku');
	}

	public function CariBuku(){
		//pencarian berdasarkan
		$berdasarkan = $this->input->post('berdasarkan');
		$key = $this->input->post('cari');

		//memasukan data kedalam array
		$data['buku'] = $this->MBuku->CariBuku($berdasarkan,$key);

		//load tampilan
		$this->Buku();
		$this->load->view('user/VUhasilcaribuku',$data);
		echo $key;
	}

	public function TambahBuku($id_buku){

		//memasukan data kedalam array
		$data = $this->MBuku->CariBuku(null,$id_buku);

		$this->MBuku->TampungBuku($data);


		$this->CariBuku();

	}

	public function DeleteTambahBuku($id_buku){

		$this->MBuku->deleteTampungBuku($id_buku);

		$this->DaftarPeminjaman();

	}

	public function DaftarPeminjaman(){

		$this->Login_Check();

		$active['status'] = $this->current;
		$active['status']['daftar_peminjaman'] = 'active';

		$data['buku'] = $this->MBuku->getTampungBuku()->result();

		$this->load->view('user/VUheader');
		$this->load->view('user/VUsidebar',$active);
		$this->load->view('user/VUcaridaftarpeminjaman',$data);
	}

	public function CariDaftarPeminjaman(){

		//input 
		$pustakawan = $this->input->post('pustakawan');
		$peminjam = $this->input->post('peminjam');

		$tanggalpinjam = date('y-m-d');
		$tanggalkembali = date('y-m-d' ,strtotime("+1 Weeks"));

		//pemindahan isi keadalam array
		$data = array(
			'id_anggota' => $peminjam,
			'id_pustakawan' => $pustakawan,
			'tanggalpinjam' => $tanggalpinjam,
			'tanggalkembali' => $tanggalkembali
		);

		$this->MBuku->TambahPeminjaman($data);
		$this->MBuku->TrunCate();
		$this->DaftarPeminjaman();
	}

	public function WaktuPengembalian(){

		$this->Login_Check();

		$active['status'] = $this->current;
		$active['status']['waktu_pengembalian'] = 'active';

		$this->load->view('user/VUheader');
		$this->load->view('user/VUsidebar',$active);
		$this->load->view('user/VUcariwaktupengembalian');
	}

	public function CariWaktuPengembalian(){

		//pencarian berdasarkan
		$berdasarkan = $this->input->post('berdasarkan');
		$key = $this->input->post('cari');

		//memasukan data kedalam array
		$data['buku'] = $this->MBuku->CariWaktuPengembalian($berdasarkan,$key);

		//load tampilan
		$this->waktu_pengembalian();
		$this->load->view('user/VUhasilcariwaktupengembalian',$data);
	}

	public function DaftarTransaksi(){

		$this->Login_Check();

		$active['status'] = $this->current;
		$active['status']['daftar_transaksi'] = 'active';

		$this->load->view('user/VUheader');
		$this->load->view('user/VUsidebar',$active);
		$this->load->view('user/VUcaridaftartransaksi');
	}

	public function CariDaftarTransaksi(){

		//pencarian berdasarkan
		$berdasarkan = $this->input->post('berdasarkan');
		$key = $this->input->post('cari');

		//memasukan data kedalam array
		$data['buku'] = $this->MBuku->CariDaftarTransaksi($berdasarkan,$key);

		//load tampilan
		$this->penerbit();
		$this->load->view('user/VUhasilcaridaftartransaksi',$data);
	}

	public function Logout(){

		$this->session->sess_destroy();
		redirect('UserHome');
	}

}
