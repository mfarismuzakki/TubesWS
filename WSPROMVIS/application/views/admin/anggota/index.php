<a href="<?php echo site_url('CAdmin/TambahAnggota');?>" class="btn btn-primary"><i class="glyphicon glyphicon-plus"></i> Tambah</a>
<hr>
<?php echo $message;?>
<Table class="table table-striped">
    <thead>
        <tr>
            <td>No.</td>
            <td>Nama</td>
            <td>Jenis Kelamin</td>
            <td>Tempat Lahir</td>
            <td>Tanggal Lahir</td>
            <td>No Telepon</td>
            <td>Alamat</td>
            <td colspan="2"></td>
        </tr>
    </thead>
    <?php $no=0; foreach($anggota as $row ): $no++;?>
    <tr>
        <td><?php echo $no;?></td>
        <td><?php echo $row->nama_anggota;?></td>
        <td><?php echo $row->jenis_kelamin;?></td>
        <td><?php echo $row->tempat_lahir;?></td>
        <td><?php echo $row->tanggal_lahir;?></td>
        <td><?php echo $row->notelepon;?></td>
        <td><?php echo $row->alamat;?></td>
        <td><a href="<?php echo site_url('CAdmin/EditAnggota/'.$row->id_anggota);?>"><i class="glyphicon glyphicon-edit"></i></a></td>
        <td><a href="#" class="hapus" kode="<?php echo $row->id_anggota;?>"><i class="glyphicon glyphicon-trash"></i></a></td>
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
                url:"<?php echo site_url('CAdmin/Hapus/AnggotaPerpustakaan');?>",
                type:"POST",
                data:"id="+kode,
                cache:false,
                success:function(html){
                    location.href="<?php echo site_url('CAdmin/Anggota/delete_success');?>";
                }
            });
        });
    });
</script>
