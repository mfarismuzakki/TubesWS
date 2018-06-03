<div class="panel-group" id="accordion">
                            <div class="panel panel-default">
                                <div class="panel-heading">
                                    <h4 class="panel-title">
                                        <a><span class="glyphicon glyphicon-folder-close"></span> Master</a>
                                    </h4>
                                </div>
                                <div>
                                    <div class="panel-body">
                                        <table class="table">
                                            <tr>
                                                <td>
                                                    <a href="<?php echo site_url('CAdmin/Anggota');?>">Anggota</a>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <a href="<?php echo site_url('CAdmin/Pustakawan');?>">Pustakawan</a>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <a href="<?php echo site_url('CAdmin/Penulis');?>">Penulis</a>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <a href="<?php echo site_url('CAdmin/Penerbit');?>">Penerbit</a>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </div>
                            </div>
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h4 class="panel-title">
                            <a><span class="glyphicon glyphicon-th"></span> Transaksi</a>
                        </h4>
                    </div>
                    <div>
                        <div class="panel-body">
                            <table class="table">
                                <tr>
                                    <td>
                                        <a href="<?php echo site_url('peminjaman');?>"> Peminjaman</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                       <a href="<?php echo site_url('pengembalian');?>"> Pengembalian</a>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h4 class="panel-title">
                            <a><span class="glyphicon glyphicon-file"></span> Laporan</a>
                        </h4>
                    </div>
                    <div>
                        <div class="panel-body">
                            <table class="table">
                                <tr>
                                    <td>
                                        </span><a href="<?php echo site_url('laporan/peminjaman');?>"> Data Peminjaman</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <a href="<?php echo site_url('laporan/pengembalian');?>"> Data Pengembalian</a>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>

                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h4 class="panel-title">
                            <a href="<?php echo site_url('CAdmin/Logout');?>"><span class="glyphicon glyphicon-off">
                            </span> Logout</a>
                        </h4>
                    </div>
                </div>
</div>