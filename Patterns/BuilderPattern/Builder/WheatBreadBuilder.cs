using BuilderPattern.Components;

namespace BuilderPattern.Builder
{
    class WheatBreadBuilder : BreadBuilder
    {
        public override void SetFlour() => this.Bread.Flour = new Flour { Sort = "Пшеничная мука высший сорт" };

        public override void SetSalt() => this.Bread.Salt = new Salt();

        public override void SetAdditives() => this.Bread.Additives = new Additives { Name = "Улучшитель хлебопекарный" };
    }
}
