<h2><?= esc($title) ?></h2>

<?= session()->getFlashdata('error') ?> <!--used to report errors related to CSRF protection.-->
<?= service('validation')->listErrors() ?> <!--used to report errors related to form validation.-->

<form action="/news/create" method="post">
    <?= csrf_field() ?> <!--creates a hidden input with a CSRF token that helps protect against some common attacks.-->

    <label for="title">Title</label>
    <input type="input" name="title" /><br />

    <label for="body">Text</label>
    <textarea name="body" cols="45" rows="4"></textarea><br />

    <input type="submit" name="submit" value="Create news item" />
</form>