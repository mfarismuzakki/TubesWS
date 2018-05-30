<?php
class Dashboard extends CI_Controller{
    
    function __construct(){
        parent::__construct();
        $this->load->library(array('form_validation','template'));
        
    }
    
    function index(){
        $data['title']="Home";
        
        $this->template->display('dashboard/index',$data);
    }
}