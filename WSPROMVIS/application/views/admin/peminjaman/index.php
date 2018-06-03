<hr>
<?php echo $message;?>
<Table class="table table-striped">
    <thead>
        <tr>
            <td>No.</td>
            <td>Nama</td>
            <td>Judul Buku</td>
            <td>Pengarang</td>
            <td>Tanggal Pinjam</td>
            <td>Tanggal Kembali</td>
            <td colspan="1"></td>
        </tr>
    </thead>
    <?php $no=0; foreach($peminjaman as $row ): $no++;?>
    <tr>
        <td><?php echo $no;?></td>
        <td><?php echo $row->nama_anggota;?></td>
        <td><?php echo $row->judul_buku;?></td>
        <td><?php echo $row->nama_penulis;?></td>
        <td><?php echo $row->tanggalpinjam;?></td>
        <td><?php echo $row->tanggalkembali;?></td>
        <td><a href="#" class="hapus" kode="<?php echo $row->id_detail_peminjaman;?>"><i class="glyphicon glyphicon-trash"></i>Kembalikan</a></td>
    </tr>
    <?php endforeach;?>
</Table>
<?php echo $pagination;?>

<script>
    $(function(){
        $(".hapus").click(function(){
            var kode=$(this).attr("kode");
            
            $("#idhapus").val(kode);
            $("#myModal").modal("show");
        });
        
        $("#konfirmasi").click(function(){
            var kode=$("#idhapus").val();
            
            $.ajax({
                url:"<?php echo site_url('CAdmin/HapusPeminjaman');?>",
                type:"POST",
                data:"id="+kode,
                cache:false,
                success:function(html){
                    location.href="<?php echo site_url('CAdmin/Peminjaman/delete_success');?>";
                }
            });
        });
    });
</script>
