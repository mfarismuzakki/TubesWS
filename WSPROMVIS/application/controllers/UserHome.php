<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class UserHome extends CI_Controller {

	public function index()
	{
		if($this->session->loged_in){
			redirect('CUsercari');
		}else{
			$this->load->view('user/VUheader');
			$this->load->view('Vlogin');
		}
	}

	public function Cek(){

		if((($this->input->post('username')) =='admin' && ($this->input->post('password') =='admin'))){
			$userdata = array(
				'username' => 'admin',
				'password' => 'admin',
				'loged_in' => TRUE
			);
			$this->session->set_userdata($userdata);

			redirect('CUserCari');
		}else{
			$this->index();
		}

	}
}
