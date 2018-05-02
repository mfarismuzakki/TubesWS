</head>
	<style type="text/css">
		@media (min-width: 768px) {
			.navbar-brand
	    	{
		        position: absolute;
		        width: 100%;
		        left: 0;
		        text-align: center;
		        margin:0 auto;
	    	}
		}
	</style>

<body>
	<!-- navigasi -->
	<nav class="navbar navbar-toggleable-md navbar-inverse fixed-top bg-inverse">
      <button class="navbar-toggler navbar-toggler-right hidden-lg-up" type="button" data-toggle="collapse" data-target="#navbarsExampleDefault" aria-controls="navbarsExampleDefault" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>
      <center>
	      <a class="navbar-brand" href="#">Perpustakaan Promvis</a>
      </center>
    </nav>

		<div class="container-fluid">
			<div class="row">
				
				<nav class="col-sm-3 col-md-2 hidden-xs-down bg-faded sidebar">
		          <ul class="nav nav-pills flex-column">
		            <li class="nav-item">
		              <a class="nav-link <?php echo element('buku',$status)?>" href="<?php echo site_url();?>/CUserCari/Buku">Buku</a>
		            </li>
		            <li class="nav-item">
		              <a class="nav-link <?php echo element('penulis',$status)?>" href="<?php echo site_url();?>/CUserCari/penulis">Penulis</a>
		            </li>
		            <li class="nav-item">
		              <a class="nav-link <?php echo element('penerbit',$status)?>" href="<?php echo site_url();?>/CUserCari/penerbit">Penerbit</a>
		            </li>
		            <li class="nav-item">
		              <a class="nav-link <?php echo element('kategori',$status)?>" href="<?php echo site_url();?>/CUserCari/Kategori">Kategori</a>
		            </li>
		            <li class="nav-item">
		              <a class="nav-link <?php echo element('bahasa',$status)?>" href="<?php echo site_url();?>/CUserCari/Bahasa">Bahasa</a>
		            </li>
		          </ul>

		          <ul class="nav nav-pills flex-column">
		            <li class="nav-item">
		              <a class="nav-link <?php echo element('daftar_peminnjaman',$status)?>" href="<?php echo site_url();?>/CUserCari/Peminjaman">Daftar Peminjaman</a>
		            </li>
		            <li class="nav-item">
		              <a class="nav-link <?php echo element('waktu_pengembalian',$status)?>" href="<?php echo site_url();?>/CUserCari/Pengembalian">Waktu Pengembalian</a>
		            </li>
		            <li class="nav-item">
		              <a class="nav-link <?php echo element('daftar_transakasi',$status)?>" href="<?php echo site_url();?>/CUserCari/Transaksi">Daftar Transaksi</a>
		            </li>
		          </ul>
		     	</nav>