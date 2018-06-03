<a href="<?php echo site_url('CAdmin/TambahBuku');?>" class="btn btn-primary"><i class="glyphicon glyphicon-plus"></i> Tambah</a>
<hr>
<?php echo $message;?>
<Table class="table table-striped">
    <thead>
        <tr>
            <td>No.</td>
            <td>Judul</td>
            <td>Cetakan</td>
            <td>Tanggal Terbit</td>
            <td>Penulis</td>
            <td>Penerbit</td>
            <td>Kategori</td>
            <td>Bahasa</td>
            <td colspan="2"></td>
        </tr>
    </thead>
    <?php $no=0; foreach($buku as $row ): $no++;?>
    <tr>
        <td><?php echo $no;?></td>
        <td><?php echo $row->judul;?></td>
        <td><?php echo $row->cetakan;?></td>
        <td><?php echo $row->tanggalterbit;?></td>
        <td><?php echo $row->penerbit;?></td>
        <td><?php echo $row->penulis;?></td>
        <td><?php echo $row->kategori;?></td>
        <td><?php echo $row->bahasa;?></td>
        <td><a href="<?php echo site_url('CAdmin/EditBuku/'.$row->id_buku);?>"><i class="glyphicon glyphicon-edit"></i></a></td>
        <td><a href="#" class="hapus" kode="<?php echo $row->id_buku;?>"><i class="glyphicon glyphicon-trash"></i></a></td>
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
                url:"<?php echo site_url('CAdmin/Hapus/Buku');?>",
                type:"POST",
                data:"id="+kode,
                cache:false,
                success:function(html){
                    location.href="<?php echo site_url('CAdmin/Buku/delete_success');?>";
                }
            });
        });
    });
</script>
