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
		              <a class="nav-link <?php echo element('buku',$status)?>" href="<?php echo site_url();?>/CUserCari/cariBuku">Buku</a>
		            </li>
		            <li class="nav-item">
		              <a class="nav-link <?php echo element('penulis',$status)?>" href="<?php echo site_url();?>/CUserCari/caripenulis">Penulis</a>
		            </li>
		            <li class="nav-item">
		              <a class="nav-link <?php echo element('penerbit',$status)?>" href="<?php echo site_url();?>/CUserCari/caripenerbit">Penerbit</a>
		            </li>
		            <li class="nav-item">
		              <a class="nav-link <?php echo element('kategori',$status)?>" href="<?php echo site_url();?>/CUserCari/cariKategori">Kategori</a>
		            </li>
		            <li class="nav-item">
		              <a class="nav-link <?php echo element('bahasa',$status)?>" href="<?php echo site_url();?>/CUserCari/cariBahasa">Bahasa</a>
		            </li>
		          </ul>

		          <ul class="nav nav-pills flex-column">
		            <li class="nav-item">
		              <a class="nav-link <?php echo element('daftar_peminjaman',$status)?>" href="<?php echo site_url();?>/CUserCari/DaftarPeminjaman">Daftar Peminjaman</a>
		            </li>
		            <!-- <li class="nav-item">
		              <a class="nav-link <?php echo element('waktu_pengembalian',$status)?>" href="<?php echo site_url();?>/CUserCari/Pengembalian">Waktu Pengembalian</a>
		            </li> -->
		            <!-- <li class="nav-item">
		              <a class="nav-link <?php echo element('daftar_transakasi',$status)?>" href="<?php echo site_url();?>/CUserCari/Transaksi">Daftar Transaksi</a>
		            </li> -->
		            <li class="nav-item">
		              <a class="nav-link" href="<?php echo site_url();?>/CUserCari/Logout">Logout</a>
		            </li>
		          </ul>
		     	</nav>
