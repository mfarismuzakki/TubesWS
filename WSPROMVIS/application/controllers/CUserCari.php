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

	//konstruktor
	function __construct(){
		parent::__construct();
		$this->load->helper('array');
		//load data
		$this->load->model('MBuku');
		$this->load->library('pagination');
	}

	function Login_Check(){

		if(!$this->session->loged_in && $this->session->username != "admin"){
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

		if($berdasarkan == 'Nama Penulis'){
			$berdasarkan = 'nama_penulis';
		}else if($berdasarkan == 'Tempat Lahir'){
			$berdasarkan = 'tempat_lahir';
		}else if($berdasarkan == 'Tanggal Lahir'){
			$berdasarkan = 'tanggal_lahir';
		}else if($berdasarkan == 'Domisili'){
			$berdasarkan = 'domisili';	
		}


		//konfigurasi pagination
		$config['base_url'] = site_url('CUserCari/CariPenulis');
		$config['total_rows'] = $this->countPenulis();
		$config['per_page'] = 5;
		$from = $this->uri->segment(3);

		$this->pagination->initialize($config);

		//memasukan data kedalam array
		$data['buku'] = $this->paginationPenulis($from);

		if($berdasarkan != ''){
			$data['buku'] = $this->MBuku->CariPenulis(null,null);

			$tampung = array();
			foreach($data['buku'] as $tmp ){
				if($tmp->$berdasarkan == $key ){
					array_push($tampung,$tmp);
				}
			}
			$data['buku'] = $tampung;
		}



		//load tampilan
		$this->Penulis();
		$this->load->view('user/VUhasilcaripenulis',$data);
	}

	public function countPenulis(){
		$data = $this->MBuku->CariPenulis(null,null);
		
		$i = 0;

		foreach($data as $tmp){
			$i++;
		}

		return $i;
	}	

	public function paginationPenulis($from){
		//memasukan data kedalam array
		$data['buku'] = $this->MBuku->CariPenulis(null,null);

		if($from == ''){
			$from = 0;
		}

		$perpage = $from + 5;
		if($perpage > $this->countPenulis()){
			$perpage = $this->countPenulis();
		}

		$tampung = array();
		for($i=$from; $i<$perpage; $i++){
			if($data['buku'][$i] != null){
				array_push($tampung,$data['buku'][$i]);
			}
		}

		return $tampung;
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
		$config['base_url'] = site_url('CUserCari/CariPenerbit');
		$config['total_rows'] = $this->countPenerbit();
		$config['per_page'] = 5;

		$from = $this->uri->segment(3);

		$this->pagination->initialize($config);

		$data['buku'] = $this->paginationPenerbit($from);

		//mengubah keyword pencarian
		if($berdasarkan == 'Nama Penerbit'){
			$berdasarkan = 'nama_penerbit';
		}else if($berdasarkan == 'Lokasi Percetakan'){
			$berdasarkan = 'lokasipercetakan';
		}else if($berdasarkan == 'No Kontak'){
			$berdasarkan = 'notelepon';
		}

		if($berdasarkan != ''){
			$data['buku'] = $this->MBuku->CariPenerbit(null,null);
			$tampung = array();
			foreach($data['buku'] as $tmp){
				if($tmp->$berdasarkan == $key){
					array_push($tampung,$tmp);	
				}
			}
			$data['buku'] = $tampung;
		}

		//load tampilan
		$this->Penerbit();
		$this->load->view('user/VUhasilcaripenerbit',$data);

	}

	public function paginationPenerbit($from){
		$data = $this->MBuku->CariPenerbit(null,null);
		$tampung = array();

		if($from == ''){
			$from = 0;
		}

		$perpage = $from + 5;

		if($perpage > $this->countPenerbit()){
			$perpage = $this->countPenerbit();
		}


		for($i=$from; $i<$perpage; $i++){
			array_push($tampung,$data[$i]);
		}

		return $tampung;
	}

	public function countPenerbit(){
		$data = $this->MBuku->CariPenerbit(null,null);
		
		$i = 0;

		foreach($data as $tmp){
			$i++;
		}

		return $i;
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
		$config['base_url'] = site_url('CUserCari/CariBahasa');
		$config['total_rows'] = $this->countBahasa();
		$config['per_page'] = 5;

		$from = $this->uri->segment(3);

		$this->pagination->initialize($config);

		$data['buku'] = $this->paginationBahasa($from);

		if($berdasarkan != ''){
			$data['buku'] = $this->MBuku->CariBahasa(null,null);
			$tampung = array();
			foreach($data['buku'] as $tmp){
				if($tmp->nama_bahasa == $key){
					array_push($tampung,$tmp);
				}
			}
			$data['buku'] = $tampung;
		}


		//load tampilan
		$this->Bahasa();
		$this->load->view('user/VUhasilcaribahasa',$data);

	}

	public function paginationBahasa($from){

		$data = $this->MBuku->CariBahasa(null,null);

		if($from == ''){
			$from = 0;
		}

		$tampung = array();

		$perpage = $from + 5;

		if($perpage > $this->countBahasa()){
			$perpage = $this->countBahasa();
		}

		for($i=$from; $i<$perpage; $i++){
			array_push($tampung,$data[$i]);
		}

		return $tampung;
	}

	public function countBahasa(){
		$data = $this->MBuku->CariBahasa(null,null);

		$i = 0;

		foreach($data as $tmp){
			$i++;
		}

		return $i;
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

		$config['base_url'] = site_url('CUserCari/CariKategori');
		$config['per_page'] = 5;
		$config['total_rows'] = $this->countKategori();

		$from = $this->uri->segment(3);

		$this->pagination->initialize($config);

		//memasukan data kedalam array
		$data['buku'] = $this->paginationKategori($from);

		if($berdasarkan != ''){	
			$data['buku'] = $this->MBuku->CariKategori(null,null);
			foreach($data['buku'] as $tmp){
				if($tmp->nama_kategori == $key){
					$tmp = array($tmp);
					$data['buku'] = $tmp;
				}
			}
		}

		//load tampilan
		$this->Kategori();
		$this->load->view('user/VUhasilcarikategori',$data);
	}

	public function paginationKategori($from){
		$data = $this->MBuku->CariKategori(null,null);

		if($from == ''){
			$from = 0;
		}

		$tampung = array();

		$perpage = $from + 5;
		if($perpage > $this->countKategori()){
			$perpage = $this->countKategori();
		}

		for($i=$from; $i<$perpage; $i++){
			array_push($tampung,$data[$i]);
		}

		return $tampung;
	}

	public function countKategori(){
		$data = $this->MBuku->CariKategori(null,null);
		$i=0;

		foreach($data as $tmp){
			$i++;
		}

		return $i;
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

		$config['base_url'] = site_url('CUserCari/CariBuku');
		$config['per_page'] = 5;
		$config['total_rows'] = $this->countBuku();

		$this->pagination->initialize($config);

		$from = $this->uri->segment(3);

		//memasukan data kedalam array
		$data['buku'] = $this->paginationBuku($from);


		if($berdasarkan != ''){

			$data['buku'] = $this->MBuku->CariBuku($berdasarkan,$key);
		}

		//load tampilan
		$this->Buku();
		$this->load->view('user/VUhasilcaribuku',$data);
	}


	public function paginationBuku($from){
		$data = $this->MBuku->CariBuku(null,null);
		
		if($from == ''){
			$from = 0;
		}	

		$perpage = $from + 5;
		if($perpage > $this->countBuku()){
			$perpage = $this->countBuku();
		}

		$tampung = array();
		for($i=$from; $i<$perpage; $i++){
			array_push($tampung,$data[$i]);
		}


		return $tampung;
	}

	public function countBuku(){
		$data = $this->MBuku->CariBuku(null,null);

		$i = 0;
		foreach($data as $tmp){
			$i++;
		}



		return $i;
	}

	public function TambahBuku($id_buku){

		//memasukan data kedalam array
		$data = $this->MBuku->CariBuku('Id',$id_buku);

		// print_r($data[0]);
		$this->MBuku->TampungBuku($data[0]);

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
		$data['pustakawan'] = $this->session->username;

		$this->load->view('user/VUheader');
		$this->load->view('user/VUsidebar',$active);
		$this->load->view('user/VUcaridaftarpeminjaman',$data);
	}

	public function CariDaftarPeminjaman(){

		//input
		$pustakawan = $this->input->post('pustakawan');
		$peminjam = $this->input->post('peminjam');

		$tanggalpinjam = date('Y-m-d');
		$tanggalkembali = date('Y-m-d' ,strtotime("+1 Weeks"));

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
